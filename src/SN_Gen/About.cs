using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SN_GEN
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            label2.Text = "Current Version: " + version;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
