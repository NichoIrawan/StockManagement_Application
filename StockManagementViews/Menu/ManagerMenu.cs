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
    public partial class ManagerMenu : Form
    {
        GudangHome? gudang;
        BarangHome? barang;
        LaporanHome? laporan;
        RiwayatHome? riwayat;
        static RiwayatHome _riwayat;
        ManagerMenu _menu;

        public ManagerMenu()
        {
            InitializeComponent();
            _menu = this;
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
                laporan = new();
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
                riwayat = new();
                riwayat.MdiParent = this;
                riwayat.Dock = DockStyle.Fill;
                riwayat.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Lavender;
            }
        }
    }
}
