using NaiveSharp.ConstText;

using System.Diagnostics;
using System.IO;

namespace NaiveSharp.Module
{
    public class Operation
    {
        public static void Save()
        {
            if (!Directory.Exists(PATH.CONFIG))
            {
                Directory.CreateDirectory(PATH.CONFIG);
            }
            File.WriteAllText(PATH.CONFIG_NODE_NS, Config.ConvertToNs());
        }

        public static void Run()
        {
            Stop();
            Save();
            // Command.InitializeTmp();
            switch (Config.RunMode.ToLower())
            {
                case "global":
                    if (!Config.Padding)
                    {
                        Command.RunNaive("http");
                        Proxy.Set(1080);
                        return;
                    }
                    Command.RunNaive("socks");
                    Command.RunPrivoxy();
                    break;
                case "geoip":
                    Command.RunNaive("socks");
                    Command.RunClash();
                    break;
                case "gfwlist":
                    Command.RunNaive("socks");
                    Command.RunPrivoxyWithGFWList();
                    break;
            }
            Proxy.Set(1081);
        }

        public static void Stop()
        {

            Process[] procs = Process.GetProcesses();
            foreach (Process item in procs)
            {
                if (item.ProcessName.ToLower() == "naive" ||
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
