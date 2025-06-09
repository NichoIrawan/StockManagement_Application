using StockManagement.Controller.UserController;
using StockManagement.Models;
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
    public partial class UserManagement : Form
    {
        List<User> userList { get; set; }
        List<User> searchList = new List<User>();
        AdminController adminCont = new AdminController();
        Form addPopup = new AddUserPopup();
        Form delPopup = new DeleteUserPopUp();
        public UserManagement()
        {
            InitializeComponent();
        }



        private void ButtonDel_Click(object sender, EventArgs e)
        {
            delPopup.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addPopup.Show();

        }

        private async void RefreshList()
        {
            tableUser.DataSource = null;
            userList = await adminCont.GetUserList();
            tableUser.DataSource = userList;
        }

        private async void UserManagement_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            
            try {
                String searchResult = searchBar.Text;
                tableUser.DataSource = null;
                searchList.Clear();
                var res = await adminCont.GetUserbyUsername(searchResult);
                if (res == null)
                {
                    MessageBox.Show("User tidak ditemukan");
                    RefreshList();
                    return;
                }
                searchList.Add(res);
                tableUser.DataSource = searchList;
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex);
            }
          
        }
    }
}
