using NaiveSharp.Module;

using System;
using System.IO;
using System.Windows.Forms;
using NaiveSharp.ConstText;
using System.Data;

namespace NaiveSharp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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

        public void LoadFromNs(string ns)
        {
            if (string.IsNullOrWhiteSpace(ns))
            {
                return;
            }

            var x = ns.Trim().Split(' ');
            if (x.Length != 2)
            {
                return;
            }

            x[0] = x[0].FromBase64();

            var uri = new Uri(x[0]);

            switch (uri.Scheme)
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

            chkPadding.Checked = bool.Parse(x[1]);
            txtHost.Text = uri.Host;
            string userinfo = uri.UserInfo.Trim();
            if (string.IsNullOrWhiteSpace(userinfo))
            {
                txtPassword.Text =
                    txtUsername.Text = "";
            }
            else
            {
                var vv = userinfo.Split(':');
                switch (vv.Length)
                {
                    case 1:
                        txtUsername.Text = vv[0];
                        break;
                    case 2:
                        txtUsername.Text = vv[0].FromUrlEncode();
                        txtPassword.Text = vv[1].FromUrlEncode();
                        break;
                    default:
                        throw new DataException();
                }
            }
        }


        private void MainWindows_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("DEBUG"))
            {
                Config.Debug = true;
                this.Text = "[DEBUG]" + this.Text;
            }
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

        #region ProxyMode

        private void rdoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGlobal.Checked)
            {
                Config.RunMode = "global";
            }
        }

        private void rdoGfwlist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGfwlist.Checked)
            {
                Config.RunMode = "gfwlist";
            }
        }

        private void rdoGeoIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGfwlist.Checked)
            {
                Config.RunMode = "geoip";
            }
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

        #region TextBox -> Config

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

        #endregion

        private void chkPadding_CheckedChanged(object sender, EventArgs e)
        {
            Config.Padding = chkPadding.Checked;
        }

    }
}
