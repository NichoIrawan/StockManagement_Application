namespace StockManagementViews.Views
{
    partial class LoginMenu
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
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Left_side;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 480);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(lblUsername);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(529, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 480);
            panel5.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(32, 309);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 11;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12.58F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(32, 224);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 10;
            label1.Text = "Password";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumPurple;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Cursor = Cursors.IBeam;
            panel3.Location = new Point(32, 245);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(16);
            panel3.Size = new Size(260, 48);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(textBox1);
            panel4.Cursor = Cursors.IBeam;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(16);
            panel4.Size = new Size(252, 40);
            panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.None;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Verdana", 9.88F);
            textBox1.Location = new Point(10, 11);
            textBox1.Margin = new Padding(16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 17);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.IBeam;
            panel1.Location = new Point(32, 162);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(260, 48);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(textBox2);
            panel2.Cursor = Cursors.IBeam;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(252, 40);
            panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AccessibleRole = AccessibleRole.None;
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Verdana", 9.88F);
            textBox2.Location = new Point(10, 11);
            textBox2.Margin = new Padding(16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 17);
            textBox2.TabIndex = 0;
            textBox2.WordWrap = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Verdana", 12.58F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MediumSlateBlue;
            lblUsername.Location = new Point(32, 141);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(853, 480);
            Controls.Add(panel5);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panel5;
        private Button button1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label lblUsername;
    }
}
