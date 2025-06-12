namespace StockManagementViews.Views
{
    partial class BarangHome
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
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnTambah = new Button();
            dataGridView1 = new DataGridView();
            kode = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Kadaluarsa = new DataGridViewTextBoxColumn();
            KodeGudang = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            btnRefresh = new Button();
            btnSearch = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblRole = new Label();
            lblName = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(34, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(241, 16);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(489, 42);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(490, 59);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.MediumSlateBlue;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Verdana", 9.88F, FontStyle.Bold);
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(457, 40);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(135, 34);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kode, Nama, Stok, Harga, Kadaluarsa, KodeGudang, Delete });
            dataGridView1.Location = new Point(24, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(576, 287);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellBeginEdit += tableBarang_CellBeginEdit;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += tableBarang_CellEndEdit;
            // 
            // kode
            // 
            kode.HeaderText = "Kode_Barang";
            kode.Name = "kode";
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama_Barang";
            Nama.Name = "Nama";
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.Name = "Stok";
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.Name = "Harga";
            // 
            // Kadaluarsa
            // 
            Kadaluarsa.HeaderText = "Tanggal_Kadaluarsa";
            Kadaluarsa.Name = "Kadaluarsa";
            // 
            // KodeGudang
            // 
            KodeGudang.HeaderText = "Kode_Gudang";
            KodeGudang.Name = "KodeGudang";
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.ForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle1;
            Delete.FlatStyle = FlatStyle.Popup;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(366, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Verdana", 7.77F, FontStyle.Bold);
            btnSearch.Location = new Point(306, 0);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 28);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(24, 24);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 83);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(381, 4);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(1, -2);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(34, 7, 0, 7);
            panel2.Size = new Size(288, 32);
            panel2.TabIndex = 18;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 20.35F, FontStyle.Bold);
            label4.Location = new Point(1, 44);
            label4.Name = "label4";
            label4.Size = new Size(128, 34);
            label4.TabIndex = 11;
            label4.Text = "Barang";
            // 
            // BarangHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BarangHome";
            Padding = new Padding(24);
            Text = "BarangHome";
            Load += BarangHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private Button btnTambah;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Button btnSearch;
        private DataGridViewTextBoxColumn kode;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Kadaluarsa;
        private DataGridViewTextBoxColumn KodeGudang;
        private DataGridViewButtonColumn Delete;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label lblName;
        private Label label4;
    }
}