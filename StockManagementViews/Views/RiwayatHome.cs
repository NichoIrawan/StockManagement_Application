using StockManagement.Controllers;
using StockManagement.Models;
using StockManagementLibrary;
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
    // 
    public partial class RiwayatHome : Form
    {
        private List<Riwayat> _listRiwayat = new List<Riwayat>();
        RiwayatController riwayatController = new RiwayatController();
        public RiwayatHome()
        {
            InitializeComponent();
        }
        private async void LoadRiwayatAsync()
        {
            try
            {
                _listRiwayat.Clear();
                TableRiwayat.DataSource = null;
                TableRiwayat.Rows.Clear();
                _listRiwayat = await riwayatController.GetListBarangAsync();
                for (int i = 0; i < _listRiwayat.Count; i++)
                {
                    TableRiwayat.Rows.Add();
                    TableRiwayat.Rows[i].Cells[0].Value = DateTime.Now;
                    TableRiwayat.Rows[i].Cells[1].Value = _listRiwayat[i].barang.namaBarang;
                    TableRiwayat.Rows[i].Cells[2].Value = _listRiwayat[i].barang.kodeBarang;
                    TableRiwayat.Rows[i].Cells[3].Value = _listRiwayat[i].lokasi_penyimpanan.kodeGudang;
                    TableRiwayat.Rows[i].Cells[4].Value = _listRiwayat[i].pic.username;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

     

        private void Riwayat_Load(object sender, EventArgs e)
        {
            LoadRiwayatAsync();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd(object sender, EventArgs e)
        {
            
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            String searchResult = textBoxSearchBar.Text;
            TableRiwayat.DataSource = null;
            TableRiwayat.Rows.Clear();
            var bar = await riwayatController.GetRiwayatgByIdAsync(DateTime.Parse(searchResult));
            if (bar == null)
            {
                MessageBox.Show("Riwayat tidak ditemukan");
                LoadRiwayatAsync();
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void ButtonRefresh(object sender, EventArgs e)
        {
            LoadRiwayatAsync();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
