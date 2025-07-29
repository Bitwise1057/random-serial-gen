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
            btnMini = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 53);
            panel2.TabIndex = 8;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 9;
            label1.Text = "About";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(38, 83);
            label2.Name = "label2";
            label2.Size = new Size(344, 38);
            label2.TabIndex = 9;
            label2.Text = "Current Version: V1.0.0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(38, 121);
            label3.Name = "label3";
            label3.Size = new Size(72, 38);
            label3.TabIndex = 10;
            label3.Text = "TBD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(39, 159);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 11;
            label4.Text = "TBD";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(448, 342);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}