using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            searchBar = new TextBox();
            label1 = new Label();
            buttonAdd = new Button();
            tableUser = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            deleteButton = new DataGridViewButtonColumn();
            lblName = new Label();
            lblRole = new Label();
            pictureBox1 = new PictureBox();
            searchButton = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)tableUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.Location = new Point(12, 23);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(200, 20);
            searchBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(147, 17);
            label1.TabIndex = 1;
            label1.Text = "User Management";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSlateBlue;
            buttonAdd.Font = new Font("Verdana", 8F);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(500, 83);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 32);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // tableUser
            // 
            tableUser.AllowUserToAddRows = false;
            tableUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableUser.BorderStyle = BorderStyle.None;
            tableUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUser.Columns.AddRange(new DataGridViewColumn[] { Username, Name, Role, deleteButton });
            tableUser.Location = new Point(12, 121);
            tableUser.Name = "tableUser";
            tableUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableUser.Size = new Size(600, 308);
            tableUser.TabIndex = 4;
            tableUser.CellBeginEdit += tableUser_CellBeginEdit;
            tableUser.CellContentClick += tableUser_CellContentClick;
            tableUser.CellEndEdit += tableUser_CellEndEdit;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // deleteButton
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.White;
            deleteButton.DefaultCellStyle = dataGridViewCellStyle2;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "Delete_row";
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(554, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(554, 43);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(513, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(218, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(55, 24);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(165, 87);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 24);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(640, 480);
            Controls.Add(btnRefresh);
            Controls.Add(searchButton);
            Controls.Add(pictureBox1);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Controls.Add(tableUser);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(searchBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 15, 5, 15);
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
        private Button buttonAdd;
        private DataGridView tableUser;
        private Label lblName;
        private Label lblRole;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn No;
        private Button searchButton;
        private Button btnRefresh;
        private DataGridViewButtonColumn deleteButton;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Role;
    }
}