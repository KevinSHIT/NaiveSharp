using NaiveSharp.Controller.Extension;

namespace NaiveSharp.Model
{
    public class Config
    {
        public static string RunMode { set; get; } = "global";

        public static string Name { set; get; } = string.Empty;

        public static string Username { set; get; } = string.Empty;

        public static string Password { set; get; } = string.Empty;

        public static string Host { set; get; } = string.Empty;

        public static string Scheme { set; get; } = "https";

        public static bool Padding { set; get; } = true;

        public static bool Debug { get; set; } = false;

        public static string ConvertToNs()
        {
            return Controller.NaiveCmdBuilder.Proxy(Scheme, Username, Password, Host).ToBase64() + " " + Padding;
        }

    }
}