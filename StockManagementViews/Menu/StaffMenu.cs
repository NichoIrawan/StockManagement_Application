using StockManagement.Models;
using StockManagementViews.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Menu
{
    public partial class StaffMenu : Form
    {
        private readonly User _user;
        private BarangHome? barang;
        private RiwayatHome? riwayat;

        private LoginMenu login = new();

        public StaffMenu(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void ResetForms()
        {
            barang = null;
            riwayat = null;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (riwayat == null)
            {
                ResetForms();
                riwayat = new(_user);
                riwayat.MdiParent = this;
                riwayat.Dock = DockStyle.Fill;
                riwayat.Show();

                button1.BackColor = Color.Lavender;
                button2.BackColor = Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
