namespace StockManagementViews.Views
{
    partial class AddGudangForm
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
            txtKodeGudang = new TextBox();
            TxtNamaGudang = new TextBox();
            TxtLokasi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTambahGudang = new Button();
            SuspendLayout();
            // 
            // txtKodeGudang
            // 
            txtKodeGudang.Location = new Point(118, 78);
            txtKodeGudang.Name = "txtKodeGudang";
            txtKodeGudang.Size = new Size(169, 23);
            txtKodeGudang.TabIndex = 0;
            // 
            // TxtNamaGudang
            // 
            TxtNamaGudang.Location = new Point(123, 115);
            TxtNamaGudang.Name = "TxtNamaGudang";
            TxtNamaGudang.Size = new Size(169, 23);
            TxtNamaGudang.TabIndex = 1;
            // 
            // TxtLokasi
            // 
            TxtLokasi.Location = new Point(123, 152);
            TxtLokasi.Name = "TxtLokasi";
            TxtLokasi.Size = new Size(169, 23);
            TxtLokasi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Masukan Gudang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "KodeGudang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "NamaGudang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 152);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Lokasi";
            // 
            // btnTambahGudang
            // 
            btnTambahGudang.Location = new Point(123, 181);
            btnTambahGudang.Name = "btnTambahGudang";
            btnTambahGudang.Size = new Size(143, 23);
            btnTambahGudang.TabIndex = 7;
            btnTambahGudang.Text = "Tambahkan Gudang";
            btnTambahGudang.UseVisualStyleBackColor = true;
            btnTambahGudang.Click += button1_Click;
            // 
            // AddGudangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 286);
            Controls.Add(btnTambahGudang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtLokasi);
            Controls.Add(TxtNamaGudang);
            Controls.Add(txtKodeGudang);
            Name = "AddGudangForm";
            Text = "AddGudangForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKodeGudang;
        private TextBox TxtNamaGudang;
        private TextBox TxtLokasi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTambahGudang;
    }
}