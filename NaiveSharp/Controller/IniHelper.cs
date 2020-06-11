using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace NaiveSharp.Controller
{
    public static class IniHelper
    {
        public static Dictionary<string, Dictionary<string, string>> FromStringArray(string[] input)
        {
            var dic = new Dictionary<string, Dictionary<string, string>>();
            string group = string.Empty;
            string tmp = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                tmp = input[i].Trim();

                if (tmp.StartsWith("[") && tmp.EndsWith("]"))
                {
                    group = tmp.Substring(1, tmp.Length - 2);
                    continue;
                }

                var kv = tmp.Split('=');

                if (kv.Length != 2)
                {
                    Debug.WriteLine($"[IniHelper] {tmp} is invalid");
                    continue;
                }
                else
                {
                    dic.Add(group, new Dictionary<string, string>
                    {
                        {kv[0], kv[1]}
                    });
                }
            }

            return dic;
        }

        public static Dictionary<string, Dictionary<string, string>> FromFile(string path)
            => FromStringArray(File.ReadAllLines(path));
    }
}