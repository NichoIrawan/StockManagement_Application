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
        NotifikasiHome? user;

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void resetForms()
        {
            gudang = null;
            user = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gudang == null)
            {
                resetForms();

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
                resetForms();

                user = new();
                user.MdiParent = this;
                user.Dock = DockStyle.Fill;
                user.Show();

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
        }
    }
}
