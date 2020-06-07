using System;
using System.Runtime.InteropServices;

namespace NaiveSharp.Module
{
    class Proxy
    {
        public static bool Set(int port)
            => Set("127.0.0.1:" + port.ToString());

        public static bool Set(string ip, int port)
            => Set(ip + ":" + port.ToString());

        public static bool Reset()
            => SetProxy(null, null);

        private static bool Set(string strProxy)
            => SetProxy(strProxy, null);


        private static bool SetProxy(string strProxy, string exceptions)
        {
            InternetPerConnOptionList list = new InternetPerConnOptionList();

            int optionCount = string.IsNullOrEmpty(strProxy) ? 1 : (string.IsNullOrEmpty(exceptions) ? 2 : 3);
            InternetConnectionOption[] options = new InternetConnectionOption[optionCount];

            options[0].m_Option = PerConnOption.INTERNET_PER_CONN_FLAGS;
            options[0].m_Value.m_Int = (int)((optionCount < 2)
                ? PerConnFlags.PROXY_TYPE_DIRECT
                : (PerConnFlags.PROXY_TYPE_DIRECT | PerConnFlags.PROXY_TYPE_PROXY));

            if (optionCount > 1)
            {
                options[1].m_Option = PerConnOption.INTERNET_PER_CONN_PROXY_SERVER;
                options[1].m_Value.m_StringPtr = Marshal.StringToHGlobalAuto(strProxy);
                if (optionCount > 2)
                {
                    options[2].m_Option = PerConnOption.INTERNET_PER_CONN_PROXY_BYPASS;
                    options[2].m_Value.m_StringPtr = Marshal.StringToHGlobalAuto(exceptions);
                }
            }

            list.dwSize = Marshal.SizeOf(list);
            list.szConnection = IntPtr.Zero;
            list.dwOptionCount = options.Length;
            list.dwOptionError = 0;

            int optSize = Marshal.SizeOf(typeof(InternetConnectionOption));
            IntPtr optionsPtr = Marshal.AllocCoTaskMem(optSize * options.Length);
            for (int i = 0; i < options.Length; ++i)
            {
                IntPtr opt = new IntPtr(optionsPtr.ToInt64() + (i * optSize));
                Marshal.StructureToPtr(options[i], opt, false);
            }

            list.options = optionsPtr;

            IntPtr ipcoListPtr = Marshal.AllocCoTaskMem((Int32)list.dwSize);
            Marshal.StructureToPtr(list, ipcoListPtr, false);

            int returnvalue = NativeMethods.InternetSetOption(IntPtr.Zero,
                InternetOption.INTERNET_OPTION_PER_CONNECTION_OPTION,
                ipcoListPtr, list.dwSize)
                ? -1
                : 0;
            if (returnvalue == 0)
            {
                returnvalue = Marshal.GetLastWin32Error();
            }

            Marshal.FreeCoTaskMem(optionsPtr);
            Marshal.FreeCoTaskMem(ipcoListPtr);
            if (returnvalue > 0)
            {
                // No need to catch
            }

            return (returnvalue < 0);
        }


        #region WinInet structures

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct InternetPerConnOptionList
        {
            public int dwSize; // size of the INTERNET_PER_CONN_OPTION_LIST struct
            public IntPtr szConnection; // connection name to set/query options
            public int dwOptionCount; // number of options to set/query

            public int dwOptionError; // on error, which option failed

            //[MarshalAs(UnmanagedType.)]
            public IntPtr options;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct InternetConnectionOption
        {
            static readonly int Size = Marshal.SizeOf(typeof(InternetConnectionOption));
            public PerConnOption m_Option;
            public InternetConnectionOptionValue m_Value;

            [StructLayout(LayoutKind.Explicit)]
            public struct InternetConnectionOptionValue
            {
                // Fields
                [FieldOffset(0)] public System.Runtime.InteropServices.ComTypes.FILETIME m_FileTime;
                [FieldOffset(0)] public int m_Int;
                [FieldOffset(0)] public IntPtr m_StringPtr;
            }
        }

        #endregion

        #region WinInet enums

        //
        // options manifests for Internet{Query|Set}Option
        //
        public enum InternetOption : uint
        {
            INTERNET_OPTION_PER_CONNECTION_OPTION = 75
        }

        //
        // Options used in INTERNET_PER_CONN_OPTON struct
        //
        public enum PerConnOption
        {
            INTERNET_PER_CONN_FLAGS =
                1, // Sets or retrieves the connection type. The Value member will contain one or more of the values from PerConnFlags
            INTERNET_PER_CONN_PROXY_SERVER = 2, // Sets or retrieves a string containing the proxy servers.

            INTERNET_PER_CONN_PROXY_BYPASS =
                3, // Sets or retrieves a string containing the URLs that do not use the proxy server.

            INTERNET_PER_CONN_AUTOCONFIG_URL =
                4 //, // Sets or retrieves a string containing the URL to the automatic configuration script.
        }

        //
        // PER_CONN_FLAGS
        //
        [Flags]
        public enum PerConnFlags
        {
            PROXY_TYPE_DIRECT = 0x00000001, // direct to net
            PROXY_TYPE_PROXY = 0x00000002, // via named proxy
            PROXY_TYPE_AUTO_PROXY_URL = 0x00000004, // autoproxy URL
            PROXY_TYPE_AUTO_DETECT = 0x00000008 // use autoproxy detection
        }

        #endregion

        internal static class NativeMethods
        {
            [DllImport("WinInet.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool InternetSetOption(IntPtr hInternet, InternetOption dwOption, IntPtr lpBuffer,
                int dwBufferLength);
        }
    }
}