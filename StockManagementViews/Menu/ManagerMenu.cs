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
    public partial class ManagerMenu : Form
    {
        GudangHome? gudang;
        BarangHome? barang;
        LaporanHome? laporan;
        RiwayatHome? riwayat;

        User user;

        readonly NotifikasiHome notifikasi = new();
        readonly LoginMenu login = new();

        public ManagerMenu(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ResetForms()
        {
            gudang = null;
            barang = null;
            laporan = null;
            riwayat = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (laporan == null)
            {
                ResetForms();
                laporan = new(user);
                laporan.MdiParent = this;
                laporan.Dock = DockStyle.Fill;
                laporan.Show();

                button1.BackColor = Color.Lavender;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (riwayat == null)
            {
                ResetForms();
                riwayat = new RiwayatHome(user);
                riwayat.MdiParent = this;
                riwayat.Dock = DockStyle.Fill;
                riwayat.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Lavender;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (barang == null)
            {
                ResetForms();
                barang = new(user);
                barang.MdiParent = this;
                barang.Dock = DockStyle.Fill;
                barang.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Lavender;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gudang == null)
            {
                ResetForms();
                gudang = new(user);
                gudang.MdiParent = this;
                gudang.Dock = DockStyle.Fill;
                gudang.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Lavender;
                button4.BackColor = Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notifikasi.Show();
        }
    }
}
