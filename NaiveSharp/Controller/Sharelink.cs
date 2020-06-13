using NaiveSharp.Controller.Extension;
using NaiveSharp.Model;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveSharp.Controller
{
    public class Sharelink
    {
        public static NaiveConfig? LoadFromShareLink(string sharelink)
        {
            var uri = new Uri(sharelink);
            var config = new NaiveConfig();
            switch (uri.Scheme)
            {
                case "naive+https":
                    config.Scheme = "https";
                    break;
                case "naive+quic":
                    config.Scheme = "quic";
                    break;
                default:
                    return null;
            }

            config.Host = uri.Host;
            config.Name = uri.Fragment;
            if (config.Name.Length > 1)
            {
                config.Name = config.Name.Substring(1);
            }
            string userinfo = uri.UserInfo.Trim();
            if (string.IsNullOrWhiteSpace(userinfo))
            {
                config.Username = config.Password = "";
            }
            else
            {
                var vv = userinfo.Split(':');
                switch (vv.Length)
                {
                    case 1:
                        config.Username = vv[0];
                        break;
                    case 2:
                        config.Username = vv[0].FromUrlEncode();
                        config.Password = vv[1].FromUrlEncode();
                        break;
                    default:
                        throw new DataException();
                }
            }
            var tmp = uri.Query;
            if (tmp.StartsWith("padding="))
            {
                if (tmp.EndsWith("true"))
                {
                    config.Padding = true;
                }
                else
                {
                    config.Padding = false;
                }
            }
            return config;
        }

        public static string Generate()
            => new UriBuilder()
            {
                Scheme = "naive+" + Config.Scheme,
                Host = Config.Host,
                UserName = Config.Username,
                Password = Config.Password,
                Query = "padding=" + Config.Padding.ToString().ToLower(),
                Fragment = Config.Name

            }.ToString();

    }

    public struct NaiveConfig
    {
        public string Name;

        public string Username;

        public string Password;

        public string Host;

        public string Scheme;

        public bool Padding;

    }
}
