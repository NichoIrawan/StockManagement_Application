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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            searchBar = new TextBox();
            buttonAdd = new Button();
            tableUser = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            deleteButton = new DataGridViewButtonColumn();
            btnRefresh = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            lblRole = new Label();
            lblName = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableUser).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Location = new Point(32, 6);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search";
            searchBar.Size = new Size(240, 20);
            searchBar.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSlateBlue;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Verdana", 8F);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(457, 42);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 32);
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
            tableUser.Location = new Point(24, 122);
            tableUser.Name = "tableUser";
            tableUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableUser.Size = new Size(592, 331);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.ForeColor = Color.White;
            deleteButton.DefaultCellStyle = dataGridViewCellStyle1;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "Delete_row";
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(300, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 24);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(lblRole);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(24, 24);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 77);
            panel2.TabIndex = 12;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(381, 4);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(searchBar);
            panel6.Location = new Point(1, -2);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(34, 7, 0, 7);
            panel6.Size = new Size(288, 32);
            panel6.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 7.77F, FontStyle.Bold);
            button2.Location = new Point(306, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(60, 28);
            button2.TabIndex = 16;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += SearchButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(409, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 7.77F);
            lblRole.Location = new Point(457, 18);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 13);
            lblRole.TabIndex = 14;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.88F, FontStyle.Bold);
            lblName.Location = new Point(457, -2);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 19);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20.35F, FontStyle.Bold);
            label2.Location = new Point(0, 42);
            label2.Name = "label2";
            label2.Size = new Size(304, 34);
            label2.TabIndex = 11;
            label2.Text = "User Management";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(640, 480);
            Controls.Add(panel2);
            Controls.Add(tableUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 15, 5, 15);
            Padding = new Padding(24);
            Text = "User Management";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)tableUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchBar;
        private Button buttonAdd;
        private DataGridView tableUser;
        private DataGridViewTextBoxColumn No;
        private Button btnRefresh;
        private DataGridViewButtonColumn deleteButton;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Role;
        private Panel panel2;
        private Button button1;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label lblName;
        private Label label2;
    }
}