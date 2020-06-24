using System.Collections.Generic;
using System.Text;

namespace NaiveSharp.Controller.Extension
{
    public static class StringArrayEx
    {
        public static string[] Trim(this string[] ss)
        {
            for (int i = 0; i < ss.Length; ++i)
            {
                ss[i] = ss[i].Trim();
            }
            return ss;
        }

        public static string[] Trim(this string[] ss, bool removeNullOrWhiteSpace)
        {
            if (!removeNullOrWhiteSpace)
            {
                return Trim(ss);
            }
            else
            {
                var x = new List<string>();
                for (int i = 0; i < ss.Length; ++i)
                {
                    if (string.IsNullOrWhiteSpace(ss[i]))
                    {
                        continue;
                    }
                    x.Add(ss[i].Trim());
                }
                return x.ToArray();
            }

        }

        public static string ToNewString(this string[] ss)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < ss.Length; ++i)
            {
                sb.Append(ss[i]);

                if (i != ss.Length - 1)
                {
                    sb.Append("\r\n");
                }
            }
            return sb.ToString();
        }

    }
}
