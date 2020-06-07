using NaiveSharp.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaiveSharp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            
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
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Operation.Run();
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            Operation.Stop();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Operation.Stop();
            Environment.Exit(0);
        }

        #endregion


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
    }
}
