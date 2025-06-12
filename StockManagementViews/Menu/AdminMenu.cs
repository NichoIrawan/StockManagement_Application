using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Models;
using StockManagementViews.Views;

namespace StockManagementViews.Menu
{
    public partial class AdminMenu : Form
    {
        GudangHome? gudang;
        UserManagement? user;
        BarangHome? barang;
        LoginMenu login = new();

        User _user;

        public AdminMenu(User user)
        {
            this._user = user;
            InitializeComponent();
        }

        private void ResetForms()
        {
            gudang = null;
            user = null;
            barang = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gudang == null)
            {
                ResetForms();

                gudang = new(_user);
                gudang.MdiParent = this;
                gudang.Dock = DockStyle.Fill;
                gudang.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Lavender;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                ResetForms();

                user = new(_user);
                user.MdiParent = this;
                user.Dock = DockStyle.Fill;
                user.Show();

                button1.BackColor = Color.Lavender;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (barang == null)
            {
                ResetForms();
                barang = new(_user);
                barang.MdiParent = this;
                barang.Dock = DockStyle.Fill;
                barang.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Lavender;
                button3.BackColor = Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
