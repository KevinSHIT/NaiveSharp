using NaiveSharp.Module;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaiveSharp
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {

        }

        private void rdoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            Config.RunMode = Operation.RunMode.Global;
        }
    }
}
