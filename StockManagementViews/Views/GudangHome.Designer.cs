namespace StockManagementViews.Views
{
    partial class GudangHome
    {
        private System.ComponentModel.IContainer components = null;

        // 🆕 Tambahkan field untuk semua komponen yang ingin digunakan di luar metode
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel circle;
        private System.Windows.Forms.DataGridView dgv;
        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            kodeGudang = new DataGridViewTextBoxColumn();
            namaGudang = new DataGridViewTextBoxColumn();
            lokasi = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnRefresh = new Button();
            btnAddGudang = new Button();
            button1 = new Button();
            panel2 = new Panel();
            txtSearch = new TextBox();
            pictureBox3 = new PictureBox();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            lblRole = new Label();
            lblName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kodeGudang, namaGudang, lokasi, btnDelete });
            dataGridView1.Location = new Point(24, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 330);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellBeginEdit += tableUser_CellBeginEdit;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += tableUser_CellEndEdit;
            // 
            // kodeGudang
            // 
            kodeGudang.HeaderText = "KodeGudang";
            kodeGudang.Name = "kodeGudang";
            // 
            // namaGudang
            // 
            namaGudang.HeaderText = "NamaGudang";
            namaGudang.Name = "namaGudang";
            // 
            // lokasi
            // 
            lokasi.HeaderText = "Lokasi";
            lokasi.Name = "lokasi";
            // 
            // btnDelete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            btnDelete.DefaultCellStyle = dataGridViewCellStyle1;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.HeaderText = "Delete_Row";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAddGudang);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(24, 24);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 77);
            panel1.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(366, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh Daftar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button3_Click;
            // 
            // btnAddGudang
            // 
            btnAddGudang.BackColor = Color.MediumSlateBlue;
            btnAddGudang.FlatAppearance.BorderSize = 0;
            btnAddGudang.FlatStyle = FlatStyle.Flat;
            btnAddGudang.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAddGudang.ForeColor = SystemColors.Control;
            btnAddGudang.Location = new Point(457, 42);
            btnAddGudang.Margin = new Padding(0);
            btnAddGudang.Name = "btnAddGudang";
            btnAddGudang.Size = new Size(135, 32);
            btnAddGudang.TabIndex = 20;
            btnAddGudang.Text = "AddGudang";
            btnAddGudang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGudang.UseVisualStyleBackColor = false;
            btnAddGudang.Click += btnAddGudang_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(1, -2);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(34, 7, 0, 7);
            panel2.Size = new Size(288, 32);
            panel2.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = true;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Verdana", 9.88F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(34, 7);
            txtSearch.Margin = new Padding(0);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(254, 18);
            txtSearch.TabIndex = 11;
            txtSearch.WordWrap = false;
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
            lblName.Font = new Font("Segoe UI", 9.88F, FontStyle.Bold);
            lblName.Location = new Point(457, -2);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 19);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.35F, FontStyle.Bold);
            label1.Location = new Point(1, 44);
            label1.Name = "label1";
            label1.Size = new Size(137, 34);
            label1.TabIndex = 11;
            label1.Text = "Gudang";
            // 
            // GudangHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(640, 480);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GudangHome";
            Padding = new Padding(24);
            StartPosition = FormStartPosition.Manual;
            Text = "GudangHome";
            Load += GudangHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kodeGudang;
        private DataGridViewTextBoxColumn namaGudang;
        private DataGridViewTextBoxColumn lokasi;
        private DataGridViewButtonColumn btnDelete;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private TextBox txtSearch;
        private PictureBox pictureBox3;
        private Button searchButton;
        private PictureBox pictureBox1;
        private Label lblRole;
        private Label lblName;
        private Label label1;
        private Button btnAddGudang;
        private Button btnRefresh;
    }
}
#endregion