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
            label4 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 30, 54);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(0, 126, 249);
            textBox1.Location = new Point(417, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(24, 30, 54);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(0, 126, 249);
            textBox2.Location = new Point(494, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 27);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(425, 53);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 2;
            label1.Text = "Prefix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(489, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(417, 112);
            button1.Name = "button1";
            button1.Size = new Size(226, 46);
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
            textBox3.Location = new Point(225, 60);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(186, 225);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 297);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.Location = new Point(12, 252);
            button4.Name = "button4";
            button4.Size = new Size(193, 33);
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
            button3.Location = new Point(12, 84);
            button3.Name = "button3";
            button3.Size = new Size(193, 66);
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
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(193, 66);
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
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 53);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(-3, 6);
            label5.Name = "label5";
            label5.Size = new Size(230, 38);
            label5.TabIndex = 12;
            label5.Text = "Serial Generator";
            // 
            // btnMini
            // 
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMini.ForeColor = Color.FromArgb(0, 126, 249);
            btnMini.Location = new Point(336, 6);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(46, 38);
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
            btnExit.Location = new Point(392, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 38);
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
            textBox4.Location = new Point(571, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(72, 27);
            textBox4.TabIndex = 8;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(574, 53);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 9;
            label3.Text = "Length";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(286, 134);
            label4.Name = "label4";
            label4.Size = new Size(313, 50);
            label4.TabIndex = 10;
            label4.Text = "Not Implemented";
            label4.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 30, 54);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 126, 249);
            btnSave.Location = new Point(417, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(226, 46);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Serial Numbers";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(663, 297);
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
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label4;
        private Button btnSave;
        private Label label5;
    }
}
