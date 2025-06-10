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
            label1 = new Label();
            textBox1 = new TextBox();
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
            Delete = new DataGridViewTextBoxColumn();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 1;
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
            btnTambah.Location = new Point(537, 59);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kode, Nama, Stok, Harga, Kadaluarsa, KodeGudang, Delete });
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 341);
            dataGridView1.TabIndex = 5;
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
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // BarangHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(dataGridView1);
            Controls.Add(btnTambah);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button btnTambah;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kode;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Kadaluarsa;
        private DataGridViewTextBoxColumn KodeGudang;
        private DataGridViewTextBoxColumn Delete;
    }
}