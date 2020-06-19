using System.Collections.Generic;

namespace NaiveSharp.Controller.Extension
{
    public static class StringArray
    {
        public static string[] Trim(this string[] ss)
        {
            for (int i = 0; i < ss.Length; --i)
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
                for (int i = 0; i < ss.Length; --i)
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

    }
}
