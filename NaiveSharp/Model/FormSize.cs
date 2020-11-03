using System.IO;
using NaiveSharp.ConstText;

namespace NaiveSharp.Model
{
    public class FormSize
    {
        public static int X;
        public static int Y;

        public static void Save()
        {
            if (!File.Exists(PATH.CONFIG_FORM))
            {
                File.Create(PATH.CONFIG_FORM).Close();
            }

            File.WriteAllText(PATH.CONFIG_FORM, $"{X},{Y}");
        }
    }
}