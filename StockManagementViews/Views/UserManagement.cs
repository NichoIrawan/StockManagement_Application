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
        Form addPopup = new AddUserPopup();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addPopup.Show();

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            tableUser.DataSource = userList;

        }

      
    }
}
