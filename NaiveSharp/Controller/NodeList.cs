using NaiveSharp.Controller.Extension;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NaiveSharp.Controller
{
    public class NodeList
    {
        public static void LoadFromStringArray(ref TreeView tv, string[] s)
        {
            tv.Nodes.Clear();
            s = s.Trim(true);

            string group = "default";

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i].StartsEndsWith("[", "]"))
                {
                    group = s[i].Substring(1, s[i].Length - 2);
                    if (!tv.Nodes.ContainsText(group))
                    {
                        tv.Nodes.Add(new TreeNode() { Name = group, Text = group });
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        tv.Nodes.Add(new TreeNode() { Name = group, Text = group });
                    }
                    try
                    {
                        tv.Nodes[group].Nodes.Add(new TreeNode()
                        {
                            Tag = s[i],
                            Text = new Uri(s[i]).Fragment.Substring(1)
                        });
                    }
                    catch (UriFormatException ufe)
                    {

                    }
                    catch (NullReferenceException)
                    {
                        // TODO: NRE
                    }
                }
            }
        }

        public static string[] ToStringArray(TreeView tv)
        {
            var l = new List<string>();
            foreach (TreeNode group in tv.Nodes)
            {
                l.Add($"[{group.Text}]");
                l.AddRange(from TreeNode node in @group.Nodes select (string) node.Tag);
            }
            return l.ToArray();
        }

    }
}