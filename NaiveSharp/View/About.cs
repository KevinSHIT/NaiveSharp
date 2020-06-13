using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NaiveSharp.View
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/KevinZonda/NaiveSharp/blob/master/LICENSE");
        }
    }
}
