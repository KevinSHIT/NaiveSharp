using NaiveSharp.ConstText;
using NaiveSharp.Model;

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NaiveSharp.Controller
{
    public static class Operation
    {
        public static void Save(ref TreeView tv)
        {
            if (!Directory.Exists(PATH.CONFIG))
            {
                Directory.CreateDirectory(PATH.CONFIG);
            }
            // File.WriteAllText(PATH.CONFIG_NODE_NS, Config.ConvertToNs());

            File.WriteAllLines(PATH.CONFIG_NODELIST, NodeList.ToStringArray(tv));
        }

        public static void Run(ref TreeView tv)
        {
            Stop();
            Save(ref tv);
            // Command.InitializeTmp();
            switch (Config.RunMode.ToLower())
            {
                case "global":
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
                case "none":
                    Command.RunNaive("socks");
                    return;
            }
            Proxy.Set(1081);
        }

        public static void Stop()
        {
            Proxy.Reset();
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
        }
    }
}
