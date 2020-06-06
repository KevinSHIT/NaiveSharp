using System;
using System.Diagnostics;

namespace NaiveSharp.Module
{
    public class NaiveCommandHelper
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
            return v.Substring(0, v.Length - 1);
        }
        
    }
}