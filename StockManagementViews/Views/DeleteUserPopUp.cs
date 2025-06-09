using StockManagement.Controller.UserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockManagementViews.Views
{
    public partial class DeleteUserPopUp : Form
    {
        AdminController adminCont;
        public DeleteUserPopUp()
        {
            InitializeComponent();
            adminCont = new AdminController();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                MessageBox.Show("Please insert a username");
                return;
            }

            try
            {
                String username = txtBoxUsername.Text;
                var res = await adminCont.GetUserbyUsername(username);
                if (res != null)
                {
                    await adminCont.deleteUser(username);
                    MessageBox.Show("Success", "User berhasil di hapus");
                    this.Hide();
                }
                else {
                    MessageBox.Show("User dengan username " + username + " tidak ditemukan, silahkan isi ulang input");
                    return;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }

        private void DeleteUserPopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
