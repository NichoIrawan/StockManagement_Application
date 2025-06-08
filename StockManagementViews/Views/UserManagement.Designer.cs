namespace StockManagementViews.Views
{
    partial class UserManagement
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
            searchBar = new TextBox();
            label1 = new Label();
            buttonDel = new Button();
            buttonAdd = new Button();
            tableUser = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            No = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tableUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.Location = new Point(12, 23);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(285, 35);
            searchBar.TabIndex = 0;
            searchBar.Text = "Search";
            searchBar.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(122, 16);
            label1.TabIndex = 1;
            label1.Text = "User Management";
            label1.Click += label1_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(382, 83);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(112, 32);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Delete user";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(500, 83);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 32);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add user";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tableUser
            // 
            tableUser.BorderStyle = BorderStyle.None;
            tableUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUser.Columns.AddRange(new DataGridViewColumn[] { No, Username, Nama, Role });
            tableUser.Location = new Point(12, 121);
            tableUser.Name = "tableUser";
            tableUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableUser.Size = new Size(600, 308);
            tableUser.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 23);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 47);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Role";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(532, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.Name = "No";
            No.Width = 50;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.Width = 318;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            Nama.Width = 318;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.Name = "Role";
            Role.Width = 110;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tableUser);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDel);
            Controls.Add(label1);
            Controls.Add(searchBar);
            Margin = new Padding(5, 15, 5, 15);
            Name = "UserManagement";
            Text = "User Management";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)tableUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBar;
        private Label label1;
        private Button buttonDel;
        private Button buttonAdd;
        private DataGridView tableUser;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Role;
    }
}