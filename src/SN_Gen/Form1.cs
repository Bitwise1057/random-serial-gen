using System.Runtime.InteropServices;
using System.Text;

// The assumption I have any idea what I'm doing is a strong one.
// This program was created with the intent of being used for Serial Number / String Generation.
// Sincerely, The Greatest Developer to Have Ever Lived. /s

namespace SN_GEN
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        // Constants for SendMessage
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown!;
            panel2.MouseDown += panel2_MouseDown!;
            label5.ForeColor = Color.FromArgb(0, 126, 249);

		}
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // Amount. Yes I know I could just name the textboxes, I'm not doing it.
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') // Denies usage of anything but numbers.
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox2.Text.Contains('.')) { e.Handled = true; }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) // Length
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') // Denies usage of anything but numbers.
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox4.Text.Contains('.')) { e.Handled = true; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Need to add auto save function for SN List.
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            btnSave.Show();
            button1.Show();
            label1.Show(); label2.Show(); label3.Show(); label4.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            btnSave.Hide();
            button1.Hide();
            label1.Hide(); label2.Hide(); label3.Hide(); label4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prefix = textBox1.Text;

            if (!int.TryParse(textBox2.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Please enter a valid positive number in TextBox2 (amount).");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int length) || length <= 0)
            {
                MessageBox.Show("Please enter a valid positive number in TextBox4 (length).");
                return;
            }

            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var output = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string randomPart = new string(Enumerable.Range(0, length)
                    .Select(_ => chars[random.Next(chars.Length)]).ToArray());

                output.AppendLine(prefix + randomPart);
            }

            textBox3.Text = output.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string output = textBox3.Text;

            if (string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("There is no content to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save Generated Strings";
                saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveDialog.FileName = "Output.txt";
                saveDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                saveDialog.DefaultExt = "txt";              // Add .txt if missing
                saveDialog.OverwritePrompt = true;          // Warn on overwrite

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveDialog.FileName, output);
                        MessageBox.Show("File saved successfully:\n" + saveDialog.FileName,
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the file:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About form2 = new About();
            form2.ShowDialog();
            
        }
    }
}
