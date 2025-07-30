namespace SN_GEN
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            btnMini = new Button();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnMini);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 40);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(10, 4);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 9;
            label1.Text = "About";
            // 
            // btnMini
            // 
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMini.ForeColor = Color.FromArgb(0, 126, 249);
            btnMini.Location = new Point(294, 4);
            btnMini.Margin = new Padding(3, 2, 3, 2);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(40, 28);
            btnMini.TabIndex = 9;
            btnMini.Text = "-";
            btnMini.UseVisualStyleBackColor = true;
            btnMini.Click += btnMini_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(0, 126, 249);
            btnExit.Location = new Point(343, 4);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 28);
            btnExit.TabIndex = 8;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(67, 49);
            label2.Name = "label2";
            label2.Size = new Size(257, 30);
            label2.TabIndex = 9;
            label2.Text = "Current Version: 1.0.0.0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(77, 152);
            label3.Name = "label3";
            label3.Size = new Size(245, 25);
            label3.TabIndex = 10;
            label3.Text = "Developed by Bitwise1057";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(18, 83);
            label4.Name = "label4";
            label4.Size = new Size(358, 63);
            label4.TabIndex = 11;
            label4.Text = "This application was developed originally for \r\nwork purposes but has since graduated to \r\nsomething more.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(13, 193);
            button1.Name = "button1";
            button1.Size = new Size(366, 51);
            button1.TabIndex = 12;
            button1.Text = "Check for Updates";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(392, 256);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnMini;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
