using NaiveSharp.Controller.Extension;
using NaiveSharp.Model;

using System;
using System.Data;
using System.Web;

namespace NaiveSharp.Controller
{
    public class Sharelink
    {
        public static NaiveConfig? LoadFromShareLink(string sharelink)
        {
            Uri uri;
            try
            {
                uri = new Uri(sharelink);
            }
            catch
            {
                return null;
            }
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
            if (uri.Port > 0)
            {
                config.Host += ":" + uri.Port;
            }
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

            var query = HttpUtility.ParseQueryString(uri.Query);

            if (!string.IsNullOrWhiteSpace(query["extra-headers"]))
            {
                config.ExtraHeaders = query["extra-headers"];
            }
            return config;
        }

        public static string Generate()
        {
            var queryC = HttpUtility.ParseQueryString(string.Empty);

            if (!string.IsNullOrWhiteSpace(Config.ExtraHeaders))
            {
                queryC.Add("extra-headers", Config.ExtraHeaders);
            }
            try
            {
                var v = Config.Host.Split(':');

                return v.Length switch
                {
                    1 => new UriBuilder()
                    {
                        Scheme = "naive+" + Config.Scheme,
                        Host = Config.Host,
                        UserName = Config.Username,
                        Password = Config.Password,
                        Query = queryC.ToString(),
                        Fragment = Config.Name

                    }.ToString(),
                    2 => new UriBuilder()
                    {
                        Scheme = "naive+" + Config.Scheme,
                        Host = v[0],
                        Port = v[1].ToInt(),
                        UserName = Config.Username,
                        Password = Config.Password,
                        Query = queryC.ToString(),
                        Fragment = Config.Name
                    }.ToString(),
                    _ => null;
                };
            }
            catch
            {
                return "";
            }
        }
    }

    public struct NaiveConfig
    {
        public string Name;

        public string Username;

        public string Password;

        public string Host;

        public string Scheme;

        public string ExtraHeaders;
    }
}
