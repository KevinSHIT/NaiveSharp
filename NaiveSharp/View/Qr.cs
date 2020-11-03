using System;
using System.Windows.Forms;


namespace NaiveSharp.View
{
    public partial class Qr : Form
    {
        public Qr(string sharelink)
        {
            InitializeComponent();

            txtSharelink.Text = qrcQrImg.Text = sharelink;
        }

        private void Qr_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSharelink_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
