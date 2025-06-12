using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Controllers.Api;
using StockManagement.Models;
using StockManagementViews.Menu;

namespace StockManagementViews.Views
{
    public partial class LaporanHome : Form
    {
        private List<Laporan> _listLaporan;
        private Laporan _laporan;
        private Gudang _gudang;
        private List<Barang> listBarang = new List<Barang>();
        private int _index = 0;

        NotifikasiHome notifikasi = new NotifikasiHome();

        private readonly LaporanController _controller = new();
        private readonly GudangController _gudangController = new();

        public LaporanHome()
        {
            InitializeComponent();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private async void LaporanHome_Load(object sender, EventArgs e)
        {
            await LoadLaporanData();
        }

        private void LoadTable()
        {
            listBarang.Clear();
            listBarang = _laporan.DaftarBarang;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listBarang.Count; i++)
            {
                int rownum = dataGridView1.Rows.Add();
                dataGridView1.Rows[rownum].Cells[0].Value = listBarang[i].namaBarang;
                dataGridView1.Rows[rownum].Cells[1].Value = listBarang[i].stok;
                dataGridView1.Rows[rownum].Cells[2].Value = listBarang[i].harga;
                dataGridView1.Rows[rownum].Cells[3].Value = listBarang[i].tanggalKadaluarsa;
            }
        }

        private async Task LoadLaporanData()
        {
            try
            {
                _index = 0;

                _listLaporan = await _controller.GetLaporanByIdAsync("G001");

                if (_listLaporan == null || _listLaporan.Count == 0)
                {
                    MessageBox.Show("No reports found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                await DisplayCurrentLaporan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DisplayCurrentLaporan()
        {
            try
            {
                if (_listLaporan == null || _index >= _listLaporan.Count)
                {
                    MessageBox.Show("Invalid list or index", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _laporan = _listLaporan.ElementAt(_index);

                if (_laporan?.TempatPenyimpanan == null)
                {
                    MessageBox.Show("Tempat Penyimpanan kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _gudang = await _gudangController.GetGudangByIdAsync(_laporan.TempatPenyimpanan);

                if (_gudang == null)
                {
                    MessageBox.Show("Gudang not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (labelGudang == null)
                {
                    MessageBox.Show("labelGudang control is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (labelTanggal == null)
                {
                    MessageBox.Show("labelTanggal control is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                labelGudang.Text = _gudang.namaGudang ?? "Unknown";
                labelTanggal.Text = $"Per {_laporan.TanggalPembuatan.ToString("dd MMMM yyyy")}";
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in DisplayCurrentLaporan:\n\nMessage: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (_index >= _listLaporan.Count - 1)
            {
                MessageBox.Show("Tidak ada laporan berikutnya!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _index++;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (_index <= 0)
            {
                MessageBox.Show("Tidak ada laporan sebelumnya!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _index--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifikasi.Show();
        }
    }
}
