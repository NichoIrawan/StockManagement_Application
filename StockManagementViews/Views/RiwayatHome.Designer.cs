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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableRiwayat = new DataGridView();
            tanngalRiwayat = new DataGridViewTextBoxColumn();
            transaksiRiwayat = new DataGridViewTextBoxColumn();
            jumlahRiwayat = new DataGridViewTextBoxColumn();
            barangRiwayat = new DataGridViewTextBoxColumn();
            lokasiRiwayat = new DataGridViewTextBoxColumn();
            picRiwayat = new DataGridViewTextBoxColumn();
            deletebtn = new DataGridViewButtonColumn();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            searchBar = new TextBox();
            pictureBox3 = new PictureBox();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            lblRole = new Label();
            lblName = new Label();
            buttonRefresh = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableRiwayat).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableRiwayat
            // 
            tableRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableRiwayat.BorderStyle = BorderStyle.None;
            tableRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableRiwayat.Columns.AddRange(new DataGridViewColumn[] { tanngalRiwayat, transaksiRiwayat, jumlahRiwayat, barangRiwayat, lokasiRiwayat, picRiwayat, deletebtn });
            tableRiwayat.Location = new Point(12, 118);
            tableRiwayat.Name = "tableRiwayat";
            tableRiwayat.Size = new Size(597, 311);
            tableRiwayat.TabIndex = 9;
            tableRiwayat.CellContentClick += TableRiwayat_CellContentClick;

            // 
            // TanngalRiwayat
            // 
            tanngalRiwayat.FillWeight = 108.892921F;
            tanngalRiwayat.HeaderText = "Tanggal";
            tanngalRiwayat.Name = "TanngalRiwayat";
            // 
            // TransaksiRiwayat
            // 
            transaksiRiwayat.FillWeight = 104.382378F;
            transaksiRiwayat.HeaderText = "Jenis Transaksi";
            transaksiRiwayat.Name = "TransaksiRiwayat";
            // 
            // JumlahRiwayat
            // 
            jumlahRiwayat.HeaderText = "Jumlah Barang";
            jumlahRiwayat.Name = "JumlahRiwayat";
            // 
            // BarangRiwayat
            // 
            barangRiwayat.FillWeight = 100.690453F;
            barangRiwayat.HeaderText = "Barang";
            barangRiwayat.Name = "BarangRiwayat";
            // 
            // LokasiRiwayat
            // 
            lokasiRiwayat.FillWeight = 97.66856F;
            lokasiRiwayat.HeaderText = "Lokasi Penyimpanan";
            lokasiRiwayat.Name = "LokasiRiwayat";
            // 
            // PicRiwayat
            // 
            picRiwayat.FillWeight = 95.1951141F;
            picRiwayat.HeaderText = "PIC";
            picRiwayat.Name = "PicRiwayat";
            // 
            // Deletebtn
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            deletebtn.DefaultCellStyle = dataGridViewCellStyle2;
            deletebtn.FillWeight = 93.17056F;
            deletebtn.FlatStyle = FlatStyle.Popup;
            deletebtn.HeaderText = "Delete";
            deletebtn.Name = "Deletebtn";
            deletebtn.Text = "Delete";
            deletebtn.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 24);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 77);
            panel1.TabIndex = 10;
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
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
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
            searchButton.Click += searchButton_Click;
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
            lblName.Font = new Font("Segoe UI", 9.88F);
            lblName.Location = new Point(457, -2);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.MediumSlateBlue;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Verdana", 9.88F, FontStyle.Bold);
            buttonRefresh.ForeColor = SystemColors.ButtonFace;
            buttonRefresh.Location = new Point(457, 42);
            buttonRefresh.Margin = new Padding(0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(135, 32);
            buttonRefresh.TabIndex = 12;
            buttonRefresh.Text = "REFRESH";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20.35F, FontStyle.Bold);
            label2.Location = new Point(1, 44);
            label2.Name = "label2";
            label2.Size = new Size(143, 34);
            label2.TabIndex = 11;
            label2.Text = "Riwayat";
            // 
            // RiwayatHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(panel1);
            Controls.Add(tableRiwayat);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "RiwayatHome";
            Text = "       ";
            Load += Riwayat_Load;
            ((System.ComponentModel.ISupportInitialize)tableRiwayat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private DataGridView tableRiwayat;
        private Panel panel1;
        private Button button1;
        private TextBox searchBar;
        private PictureBox pictureBox3;
        private Button searchButton;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label lblName;
        private Button buttonRefresh;
        private Label label2;
        private DataGridViewTextBoxColumn tanngalRiwayat;
        private DataGridViewTextBoxColumn transaksiRiwayat;
        private DataGridViewTextBoxColumn jumlahRiwayat;
        private DataGridViewTextBoxColumn barangRiwayat;
        private DataGridViewTextBoxColumn lokasiRiwayat;
        private DataGridViewTextBoxColumn picRiwayat;
        private DataGridViewButtonColumn deletebtn;
    }
}