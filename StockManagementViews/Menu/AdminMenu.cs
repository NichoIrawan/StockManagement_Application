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

namespace StockManagementViews
{
    public partial class AdminMenu : Form
    {
        GudangHome gudang;
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gudang == null)
            {
                gudang = new();
                gudang.FormClosed += gudang_formClosed;
                gudang.MdiParent = this;
                gudang.Dock = DockStyle.Fill;
                gudang.Show();

                button3.BackColor = Color.Lavender;
            }
            else
            {
                gudang.Activate();
            }
        }

        private void gudang_formClosed(object? sender, FormClosedEventArgs e)
        {
            gudang = null;
        }
    }
}
