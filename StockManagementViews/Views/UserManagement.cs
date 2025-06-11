using StockManagement.Controllers.Api;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Views
{
    public partial class UserManagement : Form
    {
        List<User> userList = new List<User>();
        List<User> searchList = new List<User>();
        UserController _userController = new();
        Form addPopup = new AddUserPopup();
        
        public UserManagement()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addPopup.Show();

        }



        private async void RefreshList()
        {
            userList.Clear();
            tableUser.DataSource = null;
            tableUser.Rows.Clear();
            userList = await _userController.GetUsersAsync();
            for (int i = 0; i < userList.Count; i++)
            {
                int rownum = tableUser.Rows.Add();
                tableUser.Rows[rownum].Cells[0].Value = userList[i].username;
                tableUser.Rows[rownum].Cells[1].Value = userList[i].name;
                tableUser.Rows[rownum].Cells[2].Value = userList[i].role;
            }
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

            try
            {
                String searchResult = searchBar.Text;
                tableUser.DataSource = null;
                tableUser.Rows.Clear();
                searchList.Clear();
                var res = await _userController.GetUserByUsernameAsync(searchResult);
                if (res == null)
                {
                    MessageBox.Show("User tidak ditemukan");
                    RefreshList();
                    return;
                }
                searchList.Add(res);
                for (int i = 0; i < searchList.Count; i++)
                {
                    int rownum = tableUser.Rows.Add();
                    tableUser.Rows[rownum].Cells[0].Value = searchList[i].username;
                    tableUser.Rows[rownum].Cells[1].Value = searchList[i].name;
                    tableUser.Rows[rownum].Cells[2].Value = searchList[i].role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private async void tableUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = tableUser.CurrentRow.Cells[0].Value.ToString();
            if (tableUser.CurrentCell == tableUser.CurrentRow.Cells[3] )
            {
                await _userController.DeleteUserAsync(username);
                tableUser.Rows.RemoveAt(e.RowIndex);
            }
            
        }

        private void tableUser_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
            if (e.ColumnIndex == 2)
            {
                e.Cancel = true;
            }
        }

        private async void tableUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow newRow = tableUser.Rows[e.RowIndex];
            string username = tableUser.CurrentRow.Cells[0].Value.ToString();

            var res = await _userController.GetUserByUsernameAsync(username);

            User usr = new User(
                username: newRow.Cells[0].Value.ToString(),
                name: newRow.Cells[1].Value.ToString(),
                role: res.role,
                password: res.password
            );

            await _userController.UpdateUserDataAsync(username, usr);
        }

    }
}
