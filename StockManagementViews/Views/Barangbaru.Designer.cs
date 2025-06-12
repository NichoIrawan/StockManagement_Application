namespace StockManagementViews.Views
{
    partial class Barangbaru
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKode = new TextBox();
            label7 = new Label();
            txtNama = new TextBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            dtpKadaluarsa = new DateTimePicker();
            txtKodeGudang = new TextBox();
            btnTambah = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 0;
            label1.Text = "Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Kode Barang            :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Barang          :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Stok                           :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 171);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 4;
            label5.Text = "Harga                        :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 206);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 5;
            label6.Text = "Tanggal Kadaluarsa :";
            // 
            // txtKode
            // 
            txtKode.Location = new Point(141, 76);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(200, 23);
            txtKode.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 242);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 7;
            label7.Text = "Kode Gudang           :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(141, 107);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 8;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(142, 137);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(199, 23);
            txtStok.TabIndex = 9;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(142, 168);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(199, 23);
            txtHarga.TabIndex = 10;
            // 
            // dtpKadaluarsa
            // 
            dtpKadaluarsa.Location = new Point(141, 200);
            dtpKadaluarsa.Name = "dtpKadaluarsa";
            dtpKadaluarsa.Size = new Size(200, 23);
            dtpKadaluarsa.TabIndex = 11;
            // 
            // txtKodeGudang
            // 
            txtKodeGudang.Location = new Point(143, 239);
            txtKodeGudang.Name = "txtKodeGudang";
            txtKodeGudang.Size = new Size(198, 23);
            txtKodeGudang.TabIndex = 12;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(22, 295);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 13;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += BtnTambah_Click;
            // 
            // Barangbaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 363);
            Controls.Add(btnTambah);
            Controls.Add(txtKodeGudang);
            Controls.Add(dtpKadaluarsa);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(txtKode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Barangbaru";
            Text = "Barangbaru";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKode;
        private Label label7;
        private TextBox txtNama;
        private TextBox txtStok;
        private TextBox txtHarga;
        private DateTimePicker dtpKadaluarsa;
        private TextBox txtKodeGudang;
        private Button btnTambah;
    }
}