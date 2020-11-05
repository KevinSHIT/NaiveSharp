using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using NaiveSharp.ConstText;
using NaiveSharp.Controller;

namespace NaiveSharp.View
{
    public partial class AdvanceWindow : Form
    {
        public AdvanceWindow()
        {
            InitializeComponent();
        }

        private static bool IsDebug()
            => File.Exists(PATH.CONFIG_DEBUG);

        private static void SetDebugStatus(bool status)
        {
            if (status)
            {
                Create(PATH.CONFIG_DEBUG);
            }
            else
            {
                Delete(PATH.CONFIG_DEBUG);
            }
        }

        private static void ResetFormSize()
            => Delete(PATH.CONFIG_FORM);

        private static void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private static void Create(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

        }

        private void AdvanceWindow_Load(object sender, System.EventArgs e)
            => btnDebug.Text = IsDebug() ? "Turn Off" : "Turn On";

        private void btnResetFormSize_Click(object sender, System.EventArgs e)
        {
            ResetFormSize();
            RequestRestart();
        }

        private void btnDebug_Click(object sender, System.EventArgs e)
        {
            if (btnDebug.Text.EndsWith("On"))
            {
                SetDebugStatus(true);
                btnDebug.Text = @"Turn Off";
            }
            else
            {
                SetDebugStatus(false);
                btnDebug.Text = @"Turn On";
            }
            RequestRestart();
        }

        private static void RequestRestart()
        {
            if (MessageBox.Show(Msg.ASK_CHANGES_NEED_APP_RESTART, Msg.Title.INFO, MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) != DialogResult.Yes) return;
            Operation.Stop();

            Process.Start(new ProcessStartInfo
            {
                FileName = Application.ExecutablePath,
                Arguments = "--no-check-running",
                WindowStyle = ProcessWindowStyle.Normal
            });
            Environment.Exit(0);
        }
    }
}