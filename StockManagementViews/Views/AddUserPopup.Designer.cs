namespace StockManagementViews.Views
{
    partial class AddUserPopup
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
            btnCancel = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtBoxUsername = new TextBox();
            txtBoxName = new TextBox();
            label2 = new Label();
            txtBoxPassword = new TextBox();
            label3 = new Label();
            comboBoxRole = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(204, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(102, 49);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(208, 23);
            txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(102, 96);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(208, 23);
            txtBoxName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(102, 149);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(208, 23);
            txtBoxPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 131);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(102, 202);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(208, 23);
            comboBoxRole.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 184);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "Role";
            // 
            // AddUserPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 307);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(comboBoxRole);
            Controls.Add(txtBoxPassword);
            Controls.Add(label3);
            Controls.Add(txtBoxName);
            Controls.Add(label2);
            Controls.Add(txtBoxUsername);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Name = "AddUserPopup";
            Text = "Add User";
            Load += AddUserPopup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label1;
        private TextBox txtBoxUsername;
        private TextBox txtBoxName;
        private Label label2;
        private TextBox txtBoxPassword;
        private Label label3;
        private ComboBox comboBoxRole;
        private Label label4;
    }
}