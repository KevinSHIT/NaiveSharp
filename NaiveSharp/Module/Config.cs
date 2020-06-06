using System.Data;

namespace NaiveSharp.Module
{
    public class Config
    {
        public static string RunMode { set; get; } = "global";

        public static string Username { set; get; } = string.Empty;

        public static string Password { set; get; } = string.Empty;

        public static string Host { set; get; } = string.Empty;

        public static string Scheme { set; get; } = "https";

        public static string ConvertToNs()
        {
            return NaiveCommandHelper.Proxy(Scheme, Username, Password, Host).ToBase64();
        }

    }
}