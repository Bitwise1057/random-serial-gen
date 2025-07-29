using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string chkdversion = await client.GetStringAsync("https://raw.githubusercontent.com/Bitwise1057/random-serial-gen/main/misc/v"); // Rudimentary update check.
                    string chkdversion1 = chkdversion.Trim();
                    string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    // string version = Application.ProductVersion; // Deprecated Check, leaving for reference.
                    // MessageBox.Show(chkdversion1); // Debugging
                    // MessageBox.Show(version); // Debugging
                    if (chkdversion1 == version)
                    {
                        MessageBox.Show("Application is currently up to date", "Update Check");
                    }
                    else
                    {
                        MessageBox.Show("New version is available. Visit the repository for current version.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error Checkign for updates: {ex.Message}", "Update Error");
                }
            }
        }
    }
}
