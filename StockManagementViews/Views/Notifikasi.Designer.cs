namespace StockManagementViews
{
    partial class Notifikasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataGridView dgvNotifications;

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblMenu = new Label();
            picUser = new PictureBox();
            lblName = new Label();
            lblRole = new Label();
            txtSearch = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            dgvNotifications = new DataGridView();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Gainsboro;
            headerPanel.Controls.Add(lblMenu);
            headerPanel.Controls.Add(picUser);
            headerPanel.Controls.Add(lblName);
            headerPanel.Controls.Add(lblRole);
            headerPanel.Controls.Add(txtSearch);
            headerPanel.Controls.Add(btn1);
            headerPanel.Controls.Add(btn2);
            headerPanel.Controls.Add(btn3);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(624, 99);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // lblMenu
            // 
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.Location = new Point(12, 14);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(100, 35);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // picUser
            // 
            picUser.BackColor = Color.White;
            picUser.BorderStyle = BorderStyle.FixedSingle;
            picUser.Location = new Point(452, 9);
            picUser.Name = "picUser";
            picUser.Size = new Size(40, 40);
            picUser.TabIndex = 1;
            picUser.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.Location = new Point(502, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 8F);
            lblRole.Location = new Point(502, 29);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search bar";
            txtSearch.Size = new Size(354, 23);
            txtSearch.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Lavender;
            btn1.Location = new Point(432, 62);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 30);
            btn1.TabIndex = 5;
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Lavender;
            btn2.Location = new Point(491, 62);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 30);
            btn2.TabIndex = 6;
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Lavender;
            btn3.Location = new Point(551, 62);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 30);
            btn3.TabIndex = 7;
            btn3.UseVisualStyleBackColor = false;
            // 
            // dgvNotifications
            // 
            dgvNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotifications.Location = new Point(12, 117);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.Size = new Size(592, 312);
            dgvNotifications.TabIndex = 1;
            // 
            // Notifikasi
            // 
            ClientSize = new Size(624, 441);
            Controls.Add(headerPanel);
            Controls.Add(dgvNotifications);
            Name = "Notifikasi";
            Text = "Notifikasi";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
