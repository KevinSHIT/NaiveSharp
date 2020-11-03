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
            CheckPath();

            if (File.Exists(ConstText.PATH.CONFIG_FORM))
            {
                var c = File.ReadAllText(PATH.CONFIG_FORM).Replace(" ", "").Split(',');
                if (c.Length == 2)
                {
                    if (int.TryParse(c[0].Trim(), out int iTX))
                        FormSize.X = iTX;
                    if (int.TryParse(c[1].Trim(), out int iTY))
                        FormSize.Y = iTY;
                }
            }
            
            // MessageBox.Show(File.ReadAllText(PATH.CONFIG_INI));
            string runMode = LoadModeConfig();

            InitializeComponent();
            Config.RunMode = runMode;
            SyncRunModeToView();

            // THIS IS FOR TEST
            // TODO: LOGIC
            // NodeList.LoadFromStringArray(ref this.tvwNodeList, new string[] { "naive+https://what:happened@test.someone.cf?padding=false#Naive!", "[222]", "naive+https://some.public.rs?padding=true#Public-01" });

            LoadFromNodeListFile();
            int?[] selectedNode = new int?[] {0, null};

            if (File.Exists(PATH.CONFIG_SELECT_NODE))
            {
                string x = File.ReadAllText(PATH.CONFIG_SELECT_NODE);
                string[] y = x.Split(',').Trim();
                try
                {
                    switch (y.Length)
                    {
                        case 1:
                            selectedNode[0] = y[0].ToInt(0);
                            break;
                        case 2:
                            selectedNode[0] = y[0].ToInt(0);
                            selectedNode[1] = y[0].ToInt(0);
                            break;
                    }
                }
                finally
                {
                    // MessageBox.Show($"READ -> {selectedNode[0]}, {selectedNode[1]}");
                    SetSelecteNode(selectedNode[0].Value, selectedNode[1]);
                }
            }
            else
            {
                File.Create(PATH.CONFIG_SELECT_NODE).Close();
                File.WriteAllText(PATH.CONFIG_SELECT_NODE, "0");
            }

            // tvwNodeList.ExpandAll();

            //NodeList.LoadFromStringArray(ref this.tvwNodeList, File.ReadAllLines(PATH.CONFIG_NODELIST));

            /*
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
            */
            if (Model.FormSize.X > 0)
                this.Width = FormSize.X;
            if (FormSize.Y > 0)
                this.Height = FormSize.Y;
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
        
        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {
            FormSize.X = Width;
            FormSize.Y = Height;
            FormSize.Save();
        }

        #region ProxyMode

        private void rdoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGlobal.Checked)
            {
                Config.RunMode = "global";
            }

            SyncRunModeToView(SyncMode.RadioToTsm);
            Config.Save();
        }

        private void rdoGfwlist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGfwlist.Checked)
            {
                Config.RunMode = "gfwlist";
            }

            SyncRunModeToView(SyncMode.RadioToTsm);
            Config.Save();
        }

        private void rdoGeoIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGeoIP.Checked)
            {
                Config.RunMode = "geoip";
            }

            SyncRunModeToView(SyncMode.RadioToTsm);
            Config.Save();
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNone.Checked)
            {
                Config.RunMode = "none";
            }

            SyncRunModeToView(SyncMode.RadioToTsm);
            Config.Save();
        }

        #endregion

        #region Operation Controller

        private void lblSave_Click(object sender, EventArgs e)
        {
            Operation.Save(ref tvwNodeList);
            // MessageBox.Show(NodeList.ToStringArray(tvwNodeList).ToNewString());
            // File.WriteAllLines(PATH.CONFIG_NODELIST, NodeList.ToStringArray(tvwNodeList));
            MessageBox.Show("Node information saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckPortStatus() == DialogResult.No)
            {
                return;
            }

            if (tvwNodeList.SelectedNode.Level == 0)
            {
                MessageBox.Show("Plz select a valid node!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Operation.Run(ref tvwNodeList);
            MessageBox.Show("NaiveProxy runs successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            MessageBox.Show("NaiveProxy stop successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            Environment.Exit(0);
        }

        #endregion

        #region Control -> Config

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            /* FIXME
            if (tvwNodeList.SelectedNode != null && tvwNodeList.SelectedNode.Level == 1)
            {
                if (tvwNodeList.SelectedNode.Level == 0)
                {
                    if (tvwNodeList.Nodes.ContainsKey(txtName.Text))
                    {
                        tvwNodeList.Enabled = false;
                        return;
                    }
                    else
                    {
                        tvwNodeList.Enabled = true;
                    }
                }
            }
            */

            tvwNodeList.SelectedNode.Name = tvwNodeList.SelectedNode.Text = txtName.Text;
            Config.Name = txtName.Text;
            SyncToTag();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Config.Username = txtUsername.Text;
            SyncToTag();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Config.Password = txtPassword.Text;
            SyncToTag();
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            Config.Host = txtHost.Text;
            SyncToTag();
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

            SyncToTag();
        }

        private void rdoQuic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHttps.Checked)
            {
                Config.Scheme = "https";
            }
            else
            {
                Config.Scheme = "quic";
            }

            SyncToTag();
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
            if (tvwNodeList.SelectedNode.Level == 0)
            {
                MessageBox.Show("Plz select a valid node!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Operation.Run(ref tvwNodeList);
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
            TreeNodeCollection tnc = null;
            if (tvwNodeList.SelectedNode != null)
            {
                if (tvwNodeList.SelectedNode.Level == 0)
                {
                    tnc = tvwNodeList.SelectedNode.Nodes;
                }
                else
                {
                    tnc = tvwNodeList.SelectedNode.Parent.Nodes;
                }
            }

            if (tnc == null) return;
            string[] x = Clipboard.GetText().Split('\n');
            if (x.Length == 0) return;
            for (int ii = 0; ii < x.Length; ++ii)
            {
                var y = Sharelink.LoadFromShareLink(x[ii]);
                if (!y.HasValue)
                {
                    return;
                }

                tnc.Add(new TreeNode()
                {
                    Tag = x,
                    Text = y.Value.Name
                });
            }


            /*
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
                */
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                if (Config.IsFirstTimeHide)
                {
                    icnNotify.ShowBalloonTip(1000, Msg.TIP_TITLE, Msg.RUNNING_UNDER_BGD,
                        ToolTipIcon.Info);
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
            if (tvwNodeList.SelectedNode.Level == 0)
            {
                // MessageBox.Show($"{tvwNodeList.SelectedNode.Index}");
                // TODO: SAVE
                File.WriteAllText(PATH.CONFIG_SELECT_NODE, $"{tvwNodeList.SelectedNode.Index}");

                txtName.Text = tvwNodeList.SelectedNode.Text;
                txtHost.Enabled = txtPassword.Enabled = txtUsername.Enabled = false;
                txtHost.Text = txtPassword.Text = txtUsername.Text = "";
                // this is group
                // tvwNodeList.SelectedNode.Expand();
            }
            else
            {
                txtHost.Enabled = txtPassword.Enabled = txtUsername.Enabled = true;

                // MessageBox.Show($"{tvwNodeList.SelectedNode.Parent.Index},{tvwNodeList.SelectedNode.Index}");

                File.WriteAllText(PATH.CONFIG_SELECT_NODE,
                    $"{tvwNodeList.SelectedNode.Parent.Index},{tvwNodeList.SelectedNode.Index}");
                var x = ((string) tvwNodeList.SelectedNode.Tag).FromSharelink();
                if (x.HasValue)
                {
                    txtName.Text = x.Value.Name;
                    txtHost.Text = x.Value.Host;
                    txtUsername.Text = x.Value.Username;
                    txtPassword.Text = x.Value.Password;
                    rdoHttps.Checked = x.Value.Scheme.Contains("https");
                    rdoQuic.Checked = x.Value.Scheme.Contains("quic");
                }
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (tvwNodeList.SelectedNode == null) return;
            TreeNodeCollection tnc;
            if (tvwNodeList.SelectedNode.Level == 0)
            {
                tnc = tvwNodeList.SelectedNode.Nodes;
            }
            else
            {
                tnc = tvwNodeList.SelectedNode.Parent.Nodes;
            }

            tnc.Add(new TreeNode() {Text = "default", Tag = "naive+https://default:default@default#default"});
        }

        private void lblAddGroup_Click(object sender, EventArgs e)
        {
            string group = "Default";
            if (tvwNodeList.Nodes.ContainsKey(group))
            {
                for (int loop = 0;; ++loop)
                {
                    if (!tvwNodeList.Nodes.ContainsKey("Default" + loop.ToString()))
                    {
                        group = "Default" + loop.ToString();
                        break;
                    }
                }
            }

            tvwNodeList.Nodes.Add(group, group);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tvwNodeList.SelectedNode != null)
            {
                if (tvwNodeList.SelectedNode.Level == 0)
                {
                    // this is group
                    if (MessageBox.Show(
                        "The nodes which belongs to the group you selected will all be deleted. Continue?",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tvwNodeList.SelectedNode.Remove();
                    }
                }
                else
                {
                    tvwNodeList.SelectedNode.Remove();
                }
            }

            tvwNodeList.Enabled = true;
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            var frmQr = new Qr(Sharelink.Generate());
            frmQr.ShowDialog();
        }
    }
}