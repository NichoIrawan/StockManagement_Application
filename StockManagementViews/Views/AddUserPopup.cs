using StockManagement.Controller.UserController;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Views
{
    public partial class AddUserPopup : Form
    {
        AdminController adminController = new AdminController();
        String[] comboBoxOption = { "Staff", "Manager" };

        public AddUserPopup()
        {
            InitializeComponent();
        }

        private void AddUserPopup_Load(object sender, EventArgs e)
        {
            comboBoxRole.DataSource = comboBoxOption;
            
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text) || 
                string.IsNullOrWhiteSpace(txtBoxName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Masih ada input yang belum terisi");
                return;
            }
            try {
                User user = new User(
                    username: txtBoxUsername.Text,
                    name: txtBoxName.Text,
                    role: (comboBoxRole.SelectedValue.Equals("Staff")) ? Roles.Staff : Roles.Manager,
                    password: txtBoxPassword.Text
                    );
                await adminController.addUser(user);
                MessageBox.Show("Success", "Berhasil menambahkan user");
                txtBoxName.Clear();
                txtBoxUsername.Clear();
                txtBoxPassword.Clear();
                this.Hide();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
