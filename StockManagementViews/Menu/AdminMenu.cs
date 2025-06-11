using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementViews.Views;

namespace StockManagementViews.Menu
{
    public partial class AdminMenu : Form
    {
        GudangHome? gudang;
        UserManagement? user;
        BarangHome? barang;

        public AdminMenu()
        {
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

                gudang = new();
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

                user = new();
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
                barang = new();
                barang.MdiParent = this;
                barang.Dock = DockStyle.Fill;
                barang.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Lavender;
                button3.BackColor = Color.Transparent;
            }
        }
    }
}
