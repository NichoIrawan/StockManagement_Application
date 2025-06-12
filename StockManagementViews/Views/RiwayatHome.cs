using StockManagement.Controller;
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
    public partial class RiwayatHome : Form
    {
        private List<Riwayat> _listRiwayat = new List<Riwayat>();
        RiwayatController _riwayatController = new RiwayatController();
        public RiwayatHome()
        {
            InitializeComponent();
        }

        // Memuat data riwayat dari controller.
        private async void LoadRiwayat()
        {
            _listRiwayat = await _riwayatController.GetListRiwayatAsync();
        }

        // Menampilkan data riwayat dalam table.
        private async Task LoadTableRiwayatAsync()
        {
            try
            {
                if (_listRiwayat.Count <= 0)
                {
                    _listRiwayat = await _riwayatController.GetListRiwayatAsync();
                }

                //_listRiwayat.Clear();
                tableRiwayat.DataSource = null;
                tableRiwayat.Rows.Clear();
                for (int i = 0; i < _listRiwayat.Count; i++)
                {
                    tableRiwayat.Rows.Add();
                    tableRiwayat.Rows[i].Cells[0].Value = _listRiwayat[i].tanggal;
                    tableRiwayat.Rows[i].Cells[1].Value = _listRiwayat[i].barang.namaBarang;
                    tableRiwayat.Rows[i].Cells[2].Value = _listRiwayat[i].jumlah_barang;
                    tableRiwayat.Rows[i].Cells[3].Value = _listRiwayat[i].barang.kodeBarang;
                    tableRiwayat.Rows[i].Cells[4].Value = _listRiwayat[i].lokasi_penyimpanan.kodeGudang;
                    tableRiwayat.Rows[i].Cells[5].Value = _listRiwayat[i].pic.username;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Load data ke dalam table.
        private void Riwayat_Load(object sender, EventArgs e)
        {
            //LoadRiwayat();
            LoadTableRiwayatAsync();
        }

        // Tombol refresh untuk memuat ulang table.
        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            _listRiwayat.Clear();
            await LoadTableRiwayatAsync();
            searchBar.Clear();

        }

        // Fungsi untuk melakukan pencarian.
        private async void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchResult = searchBar.Text;
                tableRiwayat.DataSource = null;

                if (string.IsNullOrWhiteSpace(searchResult))
                {
                    _listRiwayat.Clear();
                    await LoadTableRiwayatAsync();
                    return;
                }

                var riwayatByTanggal = await _riwayatController.GetRiwayatByTanggalAsync(DateOnly.Parse(searchResult));

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
            catch (Exception ex)
            {
                MessageBox.Show("Ada kesalahan dalam pencarian");
            }
        }

        // Fungsi untuk menghapus data dalam table.
        private async void TableRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    if (tableRiwayat.CurrentCell == tableRiwayat.CurrentRow.Cells[6])
                    {
                        var result = MessageBox.Show("Yakin mau hapus riwayat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            DateTime riwayatByTanggal = _listRiwayat[e.RowIndex].tanggal; 

                            await _riwayatController.DeleteRiwayatAsync(riwayatByTanggal);
                            _listRiwayat.RemoveAt(e.RowIndex);
                            tableRiwayat.DataSource = null;
                            tableRiwayat.Rows.Clear();
                            for (int i = 0; i < _listRiwayat.Count; i++)
                            {
                                tableRiwayat.Rows.Add();
                                tableRiwayat.Rows[i].Cells[0].Value = _listRiwayat[i].tanggal;
                                tableRiwayat.Rows[i].Cells[1].Value = _listRiwayat[i].barang.namaBarang;
                                tableRiwayat.Rows[i].Cells[2].Value = _listRiwayat[i].jumlah_barang;
                                tableRiwayat.Rows[i].Cells[3].Value = _listRiwayat[i].barang.kodeBarang;
                                tableRiwayat.Rows[i].Cells[4].Value = _listRiwayat[i].lokasi_penyimpanan.kodeGudang;
                                tableRiwayat.Rows[i].Cells[5].Value = _listRiwayat[i].pic.username;
                            }
                            MessageBox.Show("Riwayat berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
