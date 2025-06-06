namespace ManagementGUI
{
    partial class barang
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtKode = new TextBox();
            txtNama = new TextBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            dtpKadaluarsa = new DateTimePicker();
            txtKodeGudang = new TextBox();
            dgvBarang = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang           :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang          :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 3;
            label4.Text = "Stok                          :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 4;
            label5.Text = "Harga                       :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 247);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 5;
            label6.Text = "Tanggal Kadaluarsa :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 298);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 6;
            label7.Text = "Kode Gudang          :";
            // 
            // txtKode
            // 
            txtKode.Location = new Point(160, 55);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(250, 27);
            txtKode.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(160, 99);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 27);
            txtNama.TabIndex = 8;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(160, 145);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(250, 27);
            txtStok.TabIndex = 10;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(160, 192);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(250, 27);
            txtHarga.TabIndex = 11;
            // 
            // dtpKadaluarsa
            // 
            dtpKadaluarsa.Location = new Point(160, 242);
            dtpKadaluarsa.Name = "dtpKadaluarsa";
            dtpKadaluarsa.Size = new Size(250, 27);
            dtpKadaluarsa.TabIndex = 12;
            // 
            // txtKodeGudang
            // 
            txtKodeGudang.Location = new Point(160, 295);
            txtKodeGudang.Name = "txtKodeGudang";
            txtKodeGudang.Size = new Size(250, 27);
            txtKodeGudang.TabIndex = 13;
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(466, 55);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 51;
            dgvBarang.Size = new Size(566, 398);
            dgvBarang.TabIndex = 14;
            dgvBarang.CellContentClick += dgvBarang_CellContentClick;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(14, 382);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 15;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(160, 382);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(316, 382);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 17;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // barang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 495);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvBarang);
            Controls.Add(txtKodeGudang);
            Controls.Add(dtpKadaluarsa);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(txtNama);
            Controls.Add(txtKode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "barang";
            Text = "barang";
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtKode;
        private TextBox txtNama;
        private TextBox txtStok;
        private TextBox txtHarga;
        private DateTimePicker dtpKadaluarsa;
        private TextBox txtKodeGudang;
        private DataGridView dgvBarang;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
    }
}