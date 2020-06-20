using NaiveSharp.Controller;
using NaiveSharp.Model;
using NaiveSharp.Controller.Extension;

using System;
using System.IO;
using System.Windows.Forms;
using NaiveSharp.ConstText;

namespace NaiveSharp.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            SyncRunModeToView();

            // THIS IS FOR TEST
            // TODO: LOGIC
            NodeList.LoadFromStringArray(ref this.tvwNodeList, new string[] { "naive+https://what:happened@test.someone.cf?padding=false#Naive!", "[222]", "naive+https://some.public.rs?padding=true#Public-01" });

            //NodeList.LoadFromStringArray(ref this.tvwNodeList, File.ReadAllLines(PATH.CONFIG_NODELIST));

            if (File.Exists(PATH.CONFIG_NODE_NS))
            {
                try
                {
                    LoadFromNs(File.ReadAllText(PATH.CONFIG_NODE_NS));
                }
                catch
                {
                    File.Delete(PATH.CONFIG_NODE_NS);
                }
            }
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            if (File.Exists("DEBUG"))
            {
                Config.Debug = true;
                this.Text = "[DEBUG]" + this.Text;
            }
            icnNotify.Visible = true;
        }

        #region ProxyMode

        private void rdoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGlobal.Checked)
            {
                Config.RunMode = "global";
            }
            SyncRunModeToView(SyncMode.RadioToTsm);
        }

        private void rdoGfwlist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGfwlist.Checked)
            {
                Config.RunMode = "gfwlist";
            }
            SyncRunModeToView(SyncMode.RadioToTsm);
        }

        private void rdoGeoIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGeoIP.Checked)
            {
                Config.RunMode = "geoip";
            }
            SyncRunModeToView(SyncMode.RadioToTsm);
        }
        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNone.Checked)
            {
                Config.RunMode = "none";
            }
            SyncRunModeToView(SyncMode.RadioToTsm);
        }
        #endregion

        #region Operation Controller

        private void lblSave_Click(object sender, EventArgs e)
        {
            Operation.Save();

            MessageBox.Show("Node information saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckPortStatus() == DialogResult.No)
            {
                return;
            }

            Operation.Run();
            MessageBox.Show("NaiveProxy runs successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            MessageBox.Show("NaiveProxy stop successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            Environment.Exit(0);
        }

        #endregion

        #region Control -> Config

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Config.Username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Config.Password = txtPassword.Text;
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            Config.Host = txtHost.Text;
        }

        private void chkPadding_CheckedChanged(object sender, EventArgs e)
        {
            Config.Padding = chkPadding.Checked;
        }

        private void rdoHttps_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHttps.Checked)
            {
                Config.Scheme = "https";
            }
            else
            {
                Config.Scheme = "quic";
            }
        }

        #endregion

        #region SMI

        private void smiExit_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            Environment.Exit(0);
        }

        private void smiStop_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            icnNotify.ShowBalloonTip(500, "Naive #", "NaiveProxy stopped successfully.", ToolTipIcon.Info);
        }

        private void smiRun_Click(object sender, EventArgs e)
        {
            Operation.Run();
            icnNotify.ShowBalloonTip(500, "Naive #", "NaiveProxy is running.", ToolTipIcon.Info);
        }

        private void smiAbout_Click(object sender, EventArgs e)
        {
            var about = new View.About();
            about.ShowDialog();
        }

        #endregion

        private void smiCopyShareLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Sharelink.Generate());
        }

        private void smiLoadShareLink_Click(object sender, EventArgs e)
        {
            string x = Clipboard.GetText();
            var y = Sharelink.LoadFromShareLink(x);
            if (!y.HasValue)
            {
                return;
            }

            switch (y.Value.Scheme)
            {
                case "https":
                    rdoHttps.Checked = true;
                    rdoQuic.Checked = false;
                    break;
                default:
                    rdoHttps.Checked = false;
                    rdoQuic.Checked = true;
                    break;
            }

            txtHost.Text = y.Value.Host;
            txtUsername.Text = y.Value.Username;
            txtPassword.Text = y.Value.Password;
            chkPadding.Checked = y.Value.Padding ?? false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                if (Config.IsFirstTimeHide)
                {
                    icnNotify.ShowBalloonTip(1000, "Naive # Tip", "Hey! Naive # is still running under background!", ToolTipIcon.Info);
                    Config.IsFirstTimeHide = false;
                }
                e.Cancel = true;
            }
        }

        private void cmsNotify_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void icnNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            //Focus();
        }

        private void tsmGlobal_Click(object sender, EventArgs e)
        {
            Config.RunMode = "global";
            SyncRunModeToView();
        }

        private void tsmGFWList_Click(object sender, EventArgs e)
        {
            Config.RunMode = "gfwlist";
            SyncRunModeToView();
        }

        private void tsmGeoIP_Click(object sender, EventArgs e)
        {
            Config.RunMode = "geoip";
            SyncRunModeToView();
        }

        private void tsmNone_Click(object sender, EventArgs e)
        {
            Config.RunMode = "none";
            SyncRunModeToView();
        }

        private void tvwNodeList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // MessageBox.Show((string)tvwNodeList.SelectedNode.Tag);
            if ((string)tvwNodeList.SelectedNode.Tag == null)
            {
                // this is group
            }
            else
            {
                var x = ((string)tvwNodeList.SelectedNode.Tag).FromSharelink();
                if (x.HasValue)
                {
                    txtHost.Text = x.Value.Host;
                    txtUsername.Text = x.Value.Username;
                    txtPassword.Text = x.Value.Password;
                    chkPadding.Checked = x.Value.Padding ?? false;
                }
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            TreeNodeCollection tnc;
            if (tvwNodeList.SelectedNode.Level == 0)
            {
                tnc = tvwNodeList.SelectedNode.Nodes;
            }
            else
            {
                tnc = tvwNodeList.SelectedNode.Parent.Nodes;
            }
            tnc.Add(new TreeNode() { Text = "default", Tag = "naive+https://default:default@default#default" });
        }

        private void btnDelNode_Click(object sender, EventArgs e)
        {
            if (tvwNodeList.SelectedNode != null)
            {
                tvwNodeList.SelectedNode.Remove();
            }
        }

    }
}