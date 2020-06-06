using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveSharp.Module
{
    public class Operation
    {
        public enum RunMode
        {
            Global,
            GFWList,
            GeoIP
        }

        public static void Run(RunMode rm, int port)
        {

        }

        public static void Stop()
        {

            Process[] myproc = Process.GetProcesses();
            foreach (Process item in myproc)
            {
                if (item.ProcessName.ToLower() == "trojan" ||
                    item.ProcessName.ToLower() == "privoxy" ||
                    item.ProcessName.ToLower() == "clash")
                {
                    item.Kill();
                }
            }

            Proxy.Reset();
        }
    }
}
