using NaiveSharp.ConstText;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveSharp.Module
{
    public class Operation
    {
        public static void Save()
        {
            File.WriteAllText(PATH.NODE_NS, Config.ConvertToNs());
        }

        public static void Run()
        {
            Save();
            Command.InitializeTmp();
            switch (Config.RunMode.ToLower())
            {
                case "global":
                    Command.RunNaive("http");
                    Proxy.Set(1080);
                    return;
                case "geoip":
                    Command.RunClash();
                    break;
                case "gfwlist":
                    Command.RunPrivoxy();
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
