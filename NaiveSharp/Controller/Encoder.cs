using System;
using System.Text;

namespace NaiveSharp.Controller
{
    public static class Encoder
    {
        #region Base64

        public static string ConvertToBase64(string str, bool exceptionReturnSourceData = false)
        {
            try
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
            }
            catch
            {
                if (exceptionReturnSourceData)
                {
                    return str;
                }
                else
                {
                    throw new EncoderFallbackException($"{str} is not a valid string.");
                }
            }
        }

        public static string ConvertFromBase64(string str, bool exceptionReturnSourceData = false)
        {
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(str));
            }
            catch
            {
                if (exceptionReturnSourceData)
                {
                    return str;
                }
                else
                {
                    throw new EncoderFallbackException($"{str} is not a valid base64 string.");
                }
            }
        }

        #endregion
    }
}