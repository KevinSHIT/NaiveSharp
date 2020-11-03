using NaiveSharp.ConstText;
using NaiveSharp.Model;

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NaiveSharp.Controller
{
    public static class Command
    {
        // proto only accept http & socks
        public static void RunNaive(string proto)
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = PATH.NAIVE_EXE,
                    Arguments = "--proxy=" +
                                NaiveCmdBuilder.Proxy(Config.Scheme, Config.Username, Config.Password,
                                    Config.Host) +
                                " --listen=" + proto.ToLower() + "://127.0.0.1:1080"
                }
            };


            // TODO: ADD EXTRA-HEADERS SUPPORT

            if (Config.Debug)
            {
                p.StartInfo.Arguments += " --log";
                MessageBox.Show(p.StartInfo.Arguments);
                p.StartInfo.UseShellExecute = true;
            }
            else
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
            }

            p.Start();
        }

        public static void RunClash()
        {
            new Process
            {
                StartInfo =
                {
                    FileName = PATH.CLASH_EXE,
                    Arguments = $"-d {PATH.CLASH}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            }.Start();
        }

        public static void RunPrivoxyWithGFWList()
        {
            new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c START /MIN {PATH.PRIVOXY_EXE} {PATH.PRIVOXY_CONF_GFW_TXT}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            }.Start();
        }

        public static void RunPrivoxy()
        {
            new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c START /MIN {PATH.PRIVOXY_EXE} {PATH.PRIVOXY_CONF_DEF_INI}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            }.Start();
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