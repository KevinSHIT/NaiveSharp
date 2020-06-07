using System;
using System.Diagnostics;
using System.IO;
using NaiveSharp.ConstText;

namespace NaiveSharp.Module
{
    public class Command
    {
        // proto only accept http & socks
        public static void RunNaive(string proto)
        {
            var p = new Process();
            p.StartInfo.FileName = PATH.NAIVE_EXE;

            p.StartInfo.Arguments = "--proxy=" +
                                    NaiveCmdBuilder.Proxy(Config.Scheme, Config.Username, Config.Password,
                                        Config.Host) +
                                    " --listen=" + proto.ToLower() + "://127.0.0.1:1080";
            p.Start();
        }

        public static void RunClash()
        {
        }

        public static void RunPrivoxy()
        {
        }

        public static void InitializeTmp()
        {
            try
            {
                Directory.Delete(PATH.TMP, true);
            }
            finally
            {
                Directory.CreateDirectory(PATH.TMP);
            }
        }
    }
}