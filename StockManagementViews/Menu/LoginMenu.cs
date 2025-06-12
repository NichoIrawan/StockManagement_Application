using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Controllers;
using StockManagement.Models;
using StockManagementLibrary;
using StockManagementViews.Menu;

namespace StockManagementViews.Views
{
    public partial class LoginMenu : Form
    {
        Form? form;

        private LoginController _controller = new();

        public LoginMenu()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable button to prevent multiple clicks
                button1.Enabled = false;

                User user = await _controller.Login(textBox2.Text, textBox1.Text);

                switch (user.role)
                {
                    case Roles.STAFF:
                        form = new StaffMenu(user);
                        break;
                    case Roles.MANAGER:
                        form = new ManagerMenu(user);
                        break;
                    case Roles.ADMIN:
                        form = new AdminMenu(user);
                        break;
                    default:
                        MessageBox.Show("Login gagal, silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}
