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
        private System.Windows.Forms.Label lblName;
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
            txtSearch = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new DataGridViewButtonColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddGudang = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(101, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(183, 23);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "CariGudang";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnDelete });
            dataGridView1.Location = new Point(44, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(367, 250);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 28);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 64);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 110);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 5;
            label4.Text = "GudangManagement";
            // 
            // btnAddGudang
            // 
            btnAddGudang.BackColor = Color.MediumSlateBlue;
            btnAddGudang.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAddGudang.ForeColor = SystemColors.Control;
            btnAddGudang.Location = new Point(435, 110);
            btnAddGudang.Margin = new Padding(4, 3, 3, 3);
            btnAddGudang.Name = "btnAddGudang";
            btnAddGudang.Size = new Size(101, 23);
            btnAddGudang.TabIndex = 6;
            btnAddGudang.Text = "AddGudang";
            btnAddGudang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGudang.UseVisualStyleBackColor = false;
            btnAddGudang.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(336, 110);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh Daftar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button3_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(315, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button4_Click;
            // 
            // GudangHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(640, 480);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddGudang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GudangHome";
            StartPosition = FormStartPosition.Manual;
            Text = "GudangHome";
            Load += GudangHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddGudang;
        private Button btnRefresh;
        private Button btnSearch;
        private DataGridViewButtonColumn btnDelete;
    }
}
#endregion