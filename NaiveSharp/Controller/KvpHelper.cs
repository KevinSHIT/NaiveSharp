using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace NaiveSharp.Controller
{
    public static class KvpHelper
    {
        public static Dictionary<string, string> FromStringArray(string[] input)
        {
            var dic = new Dictionary<string, string>();
            string tmp = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                tmp = input[i].Trim();

                var kv = tmp.Split('=');

                if (kv.Length != 2)
                {
                    Debug.WriteLine($"[IniHelper] {tmp} is invalid");
                    continue;
                }
                else
                {
                    // MessageBox.Show($"{kv[0]}\r\n{kv[1]}");
                    dic.Add(kv[0].Trim(), kv[1].Trim()) ;
                }
            }

            return dic;
        }

        public static Dictionary<string, string> FromFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                File.WriteAllText(path, $"mode = global");
            }
            return FromStringArray(File.ReadAllLines(path));
        }
    }
}