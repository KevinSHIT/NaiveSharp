using NaiveSharp.ConstText;
using NaiveSharp.Controller;
using NaiveSharp.Controller.Extension;
using NaiveSharp.Model;

using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NaiveSharp.View
{
    public partial class MainWindow
    {
        #region sync
        enum SyncMode
        {
            RadioToTsm,
            TsmToRadio
        }

        private void SyncRunModeToView(SyncMode mode = SyncMode.TsmToRadio)
        {
            bool global = false, geoip = false, gfwlist = false, none = false;
            switch (Config.RunMode.ToLower())
            {
                case "gfwlist":
                    gfwlist = true;
                    break;
                case "global":
                    global = true;
                    break;
                case "geoip":
                    geoip = true;
                    break;
                case "none":
                    none = true;
                    break;
            }
            switch (mode)
            {
                case SyncMode.TsmToRadio:
                    tsmGlobal.Checked = rdoGlobal.Checked = global;
                    tsmGeoIP.Checked = rdoGeoIP.Checked = geoip;
                    tsmGFWList.Checked = rdoGfwlist.Checked = gfwlist;
                    tsmNone.Checked = rdoNone.Checked = none;
                    break;
                case SyncMode.RadioToTsm:
                    tsmGlobal.Checked = global;
                    tsmGeoIP.Checked = geoip;
                    tsmGFWList.Checked = gfwlist;
                    tsmNone.Checked = none;
                    break;
            }



        }
        #endregion
        private DialogResult CheckPortStatus()
        {
            /*
             * 0 -> Ok
             * 1 -> 1080
             * 2 -> 1081
             * 3 -> 1080 & 1081
             */
            int status = 0;

            if (Net.IsPortUsed(1080))
            {
                status = 1;
            }

            if (Net.IsPortUsed(1081))
            {
                if (status == 1)
                {
                    status = 3;
                }
                else
                {
                    status = 2;
                }
            }

            DialogResult result = DialogResult.OK;
            switch (status)
            {
                case 1:
                    result = MessageBox.Show("Port 1080 is in used! NaiveProxy may not work normally!\n" +
                                             "Do you still want to continue?", "Port is in used",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    break;
                case 2:
                    result = MessageBox.Show("Port 1081 is in used! HTTP proxy and padding may not work normally!\n" +
                                             "Do you still want to continue?", "Port is in used",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    break;
                case 3:
                    result = MessageBox.Show("Port 1080 is in used! NaiveProxy may not work normally!\n" +
                                             "Port 1081 is in used! HTTP proxy and padding may not work normally!\n" +
                                             "Do you still want to continue?", "Port is in used",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    break;
            }

            return result;
        }

        private void SetSelecteNode(int groupIndex, int? nodeIndex)
        {
            try
            {
                if (nodeIndex.HasValue)
                {
                    tvwNodeList.SelectedNode = tvwNodeList.Nodes[groupIndex].Nodes[nodeIndex.Value];
                }
                else
                {
                    tvwNodeList.SelectedNode = tvwNodeList.Nodes[groupIndex];
                }
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine($"Set select node failed -> [{groupIndex}][{nodeIndex}]");
            }
            catch
            {

            }
        }

        private void SetSelecteNode(int groupIndex)
        {
            try
            {
                tvwNodeList.SelectedNode = tvwNodeList.Nodes[groupIndex];
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine($"Set select node failed -> [{groupIndex}]");
            }
        }

        private void LoadFromNodeListFile()
        {
            if (!File.Exists(PATH.CONFIG_NODELIST))
            {
                File.Create(PATH.CONFIG_NODELIST).Close();
                File.WriteAllText(PATH.CONFIG_NODELIST, "[Default]");
                LoadFromNodeListFile();
            }
            else
            {
                NodeList.LoadFromStringArray(ref tvwNodeList, File.ReadAllLines(PATH.CONFIG_NODELIST));
            }
        }

        private void SyncToTag()
        {
            if (tvwNodeList.SelectedNode != null)
            {
                tvwNodeList.SelectedNode.Tag = Sharelink.Generate();
            }
        }
    }
}
