namespace StockManagementViews.Views
{
    partial class DeleteUserPopUp
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
            txtBoxUsername = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(135, 67);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(208, 23);
            txtBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(135, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteUserPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 307);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtBoxUsername);
            Name = "DeleteUserPopUp";
            Text = "DeleteUserPopUp";
            Load += DeleteUserPopUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUsername;
        private Label label1;
        private Button btnDelete;
    }
}