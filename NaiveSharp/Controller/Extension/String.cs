using static NaiveSharp.Controller.Encoder;

namespace NaiveSharp.Controller.Extension
{
    public static class String
    {
        public static string ToBase64(this string str)
            => ConvertToBase64(str, false);

        public static string FromBase64(this string str)
            => ConvertFromBase64(str, false);

        public static string FromUrlEncode(this string str)
            => System.Web.HttpUtility.UrlDecode(str);
    }
}