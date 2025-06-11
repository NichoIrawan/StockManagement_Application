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

namespace StockManagementViews.Views
{
    public partial class LoginMenu : Form
    {
        private LoginController _controller = new();

        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.Login(textBox1.Text, textBox2.Text);
        }
    }
}
