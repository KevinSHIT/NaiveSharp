using System;

namespace NaiveSharp.Controller
{
    public class NaiveCmdBuilder
    {
        public static string Proxy(string scheme, string user, string pass, string domain)
        {
            var ub = new UriBuilder()
            {
                Scheme = scheme,
                UserName = user,
                Host = domain,
                Password = pass
            };

            string v = ub.ToString();
            if (v.EndsWith("/"))
            {
                v = v.Substring(0, v.Length - 1);
            }
            return v;
        }
    }
}