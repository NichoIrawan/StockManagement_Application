namespace StockManagementViews.Views
{
    partial class RiwayatHome
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            buttonAdd = new Button();
            textBoxSearchBar = new TextBox();
            buttonRefresh = new Button();
            label2 = new Label();
            label3 = new Label();
            TableRiwayat = new DataGridView();
            TanngalRiwayat = new DataGridViewTextBoxColumn();
            TransaksiRiwayat = new DataGridViewTextBoxColumn();
            BarangRiwayat = new DataGridViewTextBoxColumn();
            LokasiRiwayat = new DataGridViewTextBoxColumn();
            PicRiwayat = new DataGridViewTextBoxColumn();
            Deletebtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TableRiwayat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 70);
            label1.Name = "label1";
            label1.Size = new Size(131, 26);
            label1.TabIndex = 2;
            label1.Text = "RIWAYAT";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.ButtonHighlight;
            buttonAdd.Location = new Point(484, 66);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd;
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.Location = new Point(11, 15);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.Size = new Size(366, 23);
            textBoxSearchBar.TabIndex = 0;
            textBoxSearchBar.TextChanged += textBox1_TextChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(393, 73);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 30);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "REFRESH";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 15);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 38);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Role";
            label3.Click += label3_Click;
            // 
            // TableRiwayat
            // 
            TableRiwayat.BorderStyle = BorderStyle.None;
            TableRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableRiwayat.Columns.AddRange(new DataGridViewColumn[] { TanngalRiwayat, TransaksiRiwayat, BarangRiwayat, LokasiRiwayat, PicRiwayat, Deletebtn });
            TableRiwayat.Location = new Point(12, 118);
            TableRiwayat.Name = "TableRiwayat";
            TableRiwayat.Size = new Size(597, 311);
            TableRiwayat.TabIndex = 9;
            // 
            // TanngalRiwayat
            // 
            TanngalRiwayat.HeaderText = "Tanggal";
            TanngalRiwayat.Name = "TanngalRiwayat";
            // 
            // TransaksiRiwayat
            // 
            TransaksiRiwayat.HeaderText = "Jenis Transaksi";
            TransaksiRiwayat.Name = "TransaksiRiwayat";
            // 
            // BarangRiwayat
            // 
            BarangRiwayat.HeaderText = "Barang";
            BarangRiwayat.Name = "BarangRiwayat";
            // 
            // LokasiRiwayat
            // 
            LokasiRiwayat.HeaderText = "Lokasi Penyimpanan";
            LokasiRiwayat.Name = "LokasiRiwayat";
            // 
            // PicRiwayat
            // 
            PicRiwayat.HeaderText = "PIC";
            PicRiwayat.Name = "PicRiwayat";
            // 
            // Deletebtn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Deletebtn.DefaultCellStyle = dataGridViewCellStyle1;
            Deletebtn.FlatStyle = FlatStyle.Popup;
            Deletebtn.HeaderText = "Delete";
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Text = "Delete";
            Deletebtn.UseColumnTextForButtonValue = true;
            // 
            // RiwayatHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(TableRiwayat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonRefresh);
            Controls.Add(textBoxSearchBar);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RiwayatHome";
            Text = "       ";
            Load += Riwayat_Load;
            ((System.ComponentModel.ISupportInitialize)TableRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Panel panel2;
        private Button buttonAdd;
        private TextBox textBoxSearchBar;
        private Button buttonRefresh;
        private Label label2;
        private Label label3;
        private DataGridView TableRiwayat;
        private DataGridViewTextBoxColumn TanngalRiwayat;
        private DataGridViewTextBoxColumn TransaksiRiwayat;
        private DataGridViewTextBoxColumn BarangRiwayat;
        private DataGridViewTextBoxColumn LokasiRiwayat;
        private DataGridViewTextBoxColumn PicRiwayat;
        private DataGridViewButtonColumn Deletebtn;
    }
}