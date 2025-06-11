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

        private async void LoadRiwayat()
        {
            _listRiwayat = await riwayatController.GetListRiwayatAsync();
        }
        private async Task LoadTableRiwayatAsync()
        {
            try
            {
                if (_listRiwayat.Count <= 0)
                {
                    _listRiwayat = await riwayatController.GetListRiwayatAsync();
                }

                //_listRiwayat.Clear();
                TableRiwayat.DataSource = null;
                TableRiwayat.Rows.Clear();
                for (int i = 0; i < _listRiwayat.Count; i++)
                {
                    TableRiwayat.Rows.Add();
                    TableRiwayat.Rows[i].Cells[0].Value = _listRiwayat[i].tanggal;
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

        private async Task BarangMasuk(Barang barang, int stok, Gudang lokasi, User pic)
        {
            Riwayat riwayat = new Riwayat(
                tanggal: DateTime.Now,
                jenis_transaksi: "Masuk",
                barang: barang,
                jumlah_barang: stok,
                lokasi_penyimpanan: lokasi,
                pic: pic
                );

            await riwayatController.InputRiwayatAsync(riwayat);
        }

        private async Task BarangKeluar(Barang barang, int stok, Gudang lokasi, User pic)
        {
            Riwayat riwayat = new Riwayat(
                tanggal: DateTime.Now,
                jenis_transaksi: "Keluar ",
                barang: barang,
                jumlah_barang: stok,
                lokasi_penyimpanan: lokasi,
                pic: pic
                );

            await riwayatController.InputRiwayatAsync(riwayat);
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            //LoadRiwayat();
            LoadTableRiwayatAsync();
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
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void ButtonRefresh(object sender, EventArgs e)
        {
            LoadTableRiwayatAsync();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            _listRiwayat.Clear();
            await LoadTableRiwayatAsync();

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string searchResult = searchBar.Text;
            TableRiwayat.DataSource = null;
            
            if (string.IsNullOrWhiteSpace(searchResult))
            {
                _listRiwayat.Clear();
                await LoadTableRiwayatAsync();
                return;
            }

            var riwayatByTanggal = await riwayatController.GetRiwayatByTanggalAsync(DateOnly.Parse(searchResult));
            
            if (riwayatByTanggal.Count <= 0)
            {
                MessageBox.Show("Riwayat tidak ditemukan");
            }
            else
            {
                _listRiwayat = riwayatByTanggal;
                await LoadTableRiwayatAsync();
            }
        }
    }
}
