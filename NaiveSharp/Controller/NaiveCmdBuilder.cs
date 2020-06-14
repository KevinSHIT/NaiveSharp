using System;

namespace NaiveSharp.Controller
{
    public static class NaiveCmdBuilder
    {
        public static string Proxy(string scheme, string user, string pass, string host)
        {
            var ub = new UriBuilder()
            {
                Scheme = scheme,
                UserName = user,
                Password = pass
            };

            var vv = host.Split(':');
            if (vv.Length == 2)
            {
                host = vv[0];
                ub.Port = int.Parse(vv[1]);
            }
            ub.Host = host;
            
            string v = ub.ToString();
            if (v.EndsWith("/"))
            {
                v = v.Substring(0, v.Length - 1);
            }
            return v;
        }
    }
}