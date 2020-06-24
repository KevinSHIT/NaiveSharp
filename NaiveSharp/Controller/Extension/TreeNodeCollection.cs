using System.Linq;
using System.Windows.Forms;

namespace NaiveSharp.Controller.Extension
{
    public static class TreeNodeCollectionEx
    {
        public static bool ContainsText(this TreeNodeCollection tnc, string text)
        {
            /*
            => tnc.Cast<TreeNode>()
                .Where(tn => tn.Text == text)
                .Count() > 0;
            */
            foreach (TreeNode tn in tnc)
            {
                if (tn.Text == text)
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountKeys(this TreeNodeCollection tnc, string text)
            => tnc.Cast<TreeNode>()
                .Where(tn => tn.Text == text)
                .Count();

        public static void Add(this TreeNodeCollection tnc, string name, string text)
            => tnc.Add(new TreeNode() { Name = name, Text = text });

        public static void Add(this TreeNodeCollection tnc, string name, string text, string tag)
            => tnc.Add(new TreeNode() { Name = name, Text = text, Tag = tag });
    }
}
