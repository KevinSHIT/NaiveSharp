using System.Collections.Generic;
using System.Windows.Forms;

namespace NaiveSharp.Controller
{
    public class NodeList
    {
        public static void LoadFromStringArray(string[] s)
        {

        }

        public static string[] ToStringArray(TreeView tv)
        {
            var l = new List<string>();
            foreach (TreeNode group in tv.Nodes)
            {
                l.Add($"[{group.Text}]");
                foreach (TreeNode node in group.Nodes)
                {
                    l.Add((string)node.Tag);
                }
            }
            return l.ToArray();
        }

    }
}