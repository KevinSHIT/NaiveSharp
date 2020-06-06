namespace NaiveSharp.Module
{
    public class Config
    {
        public static Operation.RunMode RunMode { set; get; } = Operation.RunMode.Global;

        public static string Username { set; get; } = string.Empty;

        public static string Password { set; get; } = string.Empty;

        public static string Host { set; get; } = string.Empty;
    }
}