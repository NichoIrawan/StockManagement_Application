namespace StockManagementViews.Views
{
    partial class LaporanHome
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
            panel1 = new Panel();
            panel2 = new Panel();
            searchBar = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            lblRole = new Label();
            lblName = new Label();
            buttonAdd = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Nama_Barang = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Tanggal_Kadaluarsa = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(24, 24);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 77);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(searchBar);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(1, -2);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(34, 7, 0, 7);
            panel2.Size = new Size(288, 32);
            panel2.TabIndex = 18;
            // 
            // searchBar
            // 
            searchBar.AcceptsReturn = true;
            searchBar.BackColor = Color.White;
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Verdana", 9.88F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(34, 7);
            searchBar.Margin = new Padding(0);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search";
            searchBar.Size = new Size(254, 18);
            searchBar.TabIndex = 11;
            searchBar.WordWrap = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Notif;
            pictureBox2.Location = new Point(381, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ControlLightLight;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Verdana", 7.77F, FontStyle.Bold);
            searchButton.Location = new Point(306, 0);
            searchButton.Margin = new Padding(0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(60, 28);
            searchButton.TabIndex = 16;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.avatar;
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
            lblName.Font = new Font("Segoe UI", 9.88F);
            lblName.Location = new Point(457, -2);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Verdana", 9.88F, FontStyle.Bold);
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(457, 42);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 32);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "REFRESH";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.35F, FontStyle.Bold);
            label1.Location = new Point(1, 44);
            label1.Name = "label1";
            label1.Size = new Size(144, 34);
            label1.TabIndex = 11;
            label1.Text = "Laporan";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(24, 101);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 16, 0, 0);
            panel3.Size = new Size(592, 355);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(40, 16);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 339);
            panel4.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama_Barang, Stok, Harga, Tanggal_Kadaluarsa });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(512, 259);
            dataGridView1.TabIndex = 1;
            // 
            // Nama_Barang
            // 
            Nama_Barang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama_Barang.HeaderText = "Nama Barang";
            Nama_Barang.Name = "Nama_Barang";
            Nama_Barang.ReadOnly = true;
            // 
            // Stok
            // 
            Stok.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Stok.HeaderText = "Stok";
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            Stok.Width = 55;
            // 
            // Harga
            // 
            Harga.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Harga.HeaderText = "Harga";
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            Harga.Width = 64;
            // 
            // Tanggal_Kadaluarsa
            // 
            Tanggal_Kadaluarsa.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Tanggal_Kadaluarsa.HeaderText = "Tanggal Kadaluarsa";
            Tanggal_Kadaluarsa.Name = "Tanggal_Kadaluarsa";
            Tanggal_Kadaluarsa.ReadOnly = true;
            Tanggal_Kadaluarsa.Width = 134;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(512, 80);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 9.55F);
            label3.Location = new Point(0, 45);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 4, 0, 0);
            label3.Size = new Size(512, 35);
            label3.TabIndex = 1;
            label3.Text = "per <Tanggal>";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Verdana", 12.58F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 16, 0, 0);
            label2.Size = new Size(512, 45);
            label2.TabIndex = 0;
            label2.Text = "Gudang Jaya";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Image = Properties.Resources.arrow_left;
            pictureBox6.Location = new Point(0, 16);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 339);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Right;
            pictureBox5.Image = Properties.Resources.arrow_right;
            pictureBox5.Location = new Point(552, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 339);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // LaporanHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(640, 480);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 15, 5, 15);
            Name = "LaporanHome";
            Padding = new Padding(24);
            Text = "User Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView tableUser;
        private Panel panel1;
        private Panel panel2;
        private TextBox searchBar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button searchButton;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label lblName;
        private Button buttonAdd;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private Panel panel5;
        private DataGridViewTextBoxColumn Nama_Barang;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Tanggal_Kadaluarsa;
        private Label label3;
        private Label label2;
    }
}