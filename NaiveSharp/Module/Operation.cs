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

        }

        public static void Stop()
        {

            Process[] myproc = Process.GetProcesses();
            foreach (Process item in myproc)
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
