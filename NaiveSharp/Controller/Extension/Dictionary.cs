using System.Collections.Generic;

namespace NaiveSharp.Controller.Extension
{
    public static class DictionaryEx
    {
        public static bool HasKey<K, V>(this Dictionary<K, V> dic, K value)
            => dic.ContainsKey(value);
    }
}