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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Barang";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(241, 23);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 18);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(466, 35);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.MediumSlateBlue;
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(537, 59);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 28);
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
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 341);
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
            btnRefresh.Location = new Point(94, 54);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(259, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // BarangHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(btnTambah);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "BarangHome";
            Text = "BarangHome";
            Load += BarangHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}