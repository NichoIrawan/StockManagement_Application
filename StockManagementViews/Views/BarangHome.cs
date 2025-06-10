using StockManagement.Controller.UserController;
using StockManagement.Controllers;
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
    public partial class BarangHome : Form
    {
        List<Barang> barangList = new List<Barang>();
        List<Barang> searchList = new List<Barang>();
        BarangController barangCont = new BarangController();
        Form addBarangbaru = new Barangbaru();
        public BarangHome()
        {
            InitializeComponent();
        }

        private void BarangHome_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            addBarangbaru.Show();
        }

        private async void RefreshList()
        {
            barangList.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            barangList = await barangCont.tampilkanBarang();
            for (int i = 0; i < barangList.Count; i++)
            {
                int rownum = dataGridView1.Rows.Add();
               
            }
        }
    }
}
