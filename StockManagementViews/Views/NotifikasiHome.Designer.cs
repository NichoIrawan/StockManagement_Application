namespace StockManagementViews
{
    partial class NotifikasiHome
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
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dgvNotifications;

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblMenu = new Label();
            btn1 = new Button();
            dgvNotifications = new DataGridView();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Gainsboro;
            headerPanel.Controls.Add(lblMenu);
            headerPanel.Controls.Add(btn1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(624, 99);
            headerPanel.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMenu.Location = new Point(12, 14);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(136, 35);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Notifikasi";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Lavender;
            btn1.Location = new Point(555, 14);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 30);
            btn1.TabIndex = 5;
            btn1.Text = "Refresh";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // dgvNotifications
            // 
            dgvNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotifications.Location = new Point(12, 117);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.Size = new Size(592, 312);
            dgvNotifications.TabIndex = 1;
            // 
            // NotifikasiHome
            // 
            ClientSize = new Size(624, 441);
            Controls.Add(headerPanel);
            Controls.Add(dgvNotifications);
            Name = "NotifikasiHome";
            Text = "Notifikasi";
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
