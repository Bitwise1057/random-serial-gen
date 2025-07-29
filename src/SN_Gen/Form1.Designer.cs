namespace SN_GEN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            btnMini = new Button();
            btnExit = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            panel3 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 30, 54);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(0, 126, 249);
            textBox1.Location = new Point(365, 59);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(24, 30, 54);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(0, 126, 249);
            textBox2.Location = new Point(432, 59);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(372, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Prefix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(428, 40);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(365, 84);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(198, 34);
            button1.TabIndex = 4;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(24, 30, 54);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(0, 126, 249);
            textBox3.Location = new Point(197, 45);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(163, 169);
            textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 223);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(10, 185);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(169, 29);
            button4.TabIndex = 10;
            button4.Text = "About";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.Location = new Point(10, 63);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(169, 50);
            button3.TabIndex = 9;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(10, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(169, 50);
            button2.TabIndex = 8;
            button2.Text = "Generator";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnMini);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(190, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 40);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(-3, 4);
            label5.Name = "label5";
            label5.Size = new Size(181, 30);
            label5.TabIndex = 12;
            label5.Text = "Serial Generator";
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
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(24, 30, 54);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = Color.FromArgb(0, 126, 249);
            textBox4.Location = new Point(500, 59);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 8;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(502, 40);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "Length";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 30, 54);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 126, 249);
            btnSave.Location = new Point(365, 123);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Serial Numbers";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox1);
            panel3.Location = new Point(193, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 169);
            panel3.TabIndex = 12;
            panel3.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(0, 126, 249);
            checkBox2.Location = new Point(5, 42);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(278, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Auto Update (Not Implemented)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 126, 249);
            checkBox1.Location = new Point(5, 11);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Auto-Save On Exit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.Location = new Point(6, 72);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(169, 29);
            button5.TabIndex = 11;
            button5.Text = "Save Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(580, 223);
            Controls.Add(panel3);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Panel panel1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private Button btnMini;
        private Button btnExit;
        private TextBox textBox4;
        private Label label3;
        private Button btnSave;
        private Label label5;
        private Panel panel3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button5;
    }
}
