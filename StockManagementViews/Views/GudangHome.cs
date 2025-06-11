using StockManagement.Controller;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Views
{
    public partial class GudangHome : Form
    {
        private GudangController _gudangController = new();
        private List<Gudang> _listGudang = new List<Gudang>();
        private List<Gudang> _searchResult = new List<Gudang>();

        public GudangHome()
        {
            InitializeComponent();
        }

        //Looad GUI GudangHome
        private async void GudangHome_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //Load DataGudang pada DataGrid 


        //Tampilkan PopUp untuk AddGudang
        private void _btnAddGudangClick(object sender, EventArgs e)
        {
            AddGudangForm addGudangForm = new AddGudangForm();
            addGudangForm.Show();
        }

        //Memuat ulang DataGudang pada DataGrid
        private async void _btnRefreshClick(object sender, EventArgs e)
        {
            Refresh();
        }

        private async void Refresh()
        {
            _listGudang.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            _listGudang = await _gudangController.GetListGudangAsync();
            for (int i = 0; i < _listGudang.Count; i++)
            {
                int rownum = dataGridView1.Rows.Add();
                dataGridView1.Rows[rownum].Cells[0].Value = _listGudang[i].kodeGudang;
                dataGridView1.Rows[rownum].Cells[1].Value = _listGudang[i].namaGudang;
                dataGridView1.Rows[rownum].Cells[2].Value = _listGudang[i].lokasi;
            }
        }

        //Mencari Gudang dalam DataGrid berdasarkan kodeGudang
        private async void _btnSearchClick(object sender, EventArgs e)
        {

        }

        //Menghapus 1 baris data Gudang dalam DataGrid 
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == dataGridView1.CurrentRow.Cells[3])
                {
                    var result = MessageBox.Show("Yakin mau hapus gudang ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string idToDelete = _listGudang[e.RowIndex].kodeGudang; // Pastikan Id property bener

                        await _gudangController.DeleteGudangAsync(idToDelete);
                        _listGudang.RemoveAt(e.RowIndex);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = _listGudang;
                        MessageBox.Show("Gudang berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableUser_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }

        }

        private async void tableUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow newRow = dataGridView1.Rows[e.RowIndex];
            string kodeGudang = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var res = await _gudangController.GetGudangByIdAsync(kodeGudang);

            Gudang gdg = new Gudang(
                kodeGudang: res.kodeGudang,
                namaGudang: newRow.Cells[1].Value.ToString(),
                lokasi: newRow.Cells[2].Value.ToString()
            );
            MessageBox.Show("Kolom berhasil dirubah");

            await _gudangController.UpdateGudangAsync(kodeGudang, gdg);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            dataGridView1.DataSource = null;
            _searchResult.Clear();
            try
            {
                var res = await _gudangController.GetGudangByIdAsync(search);
                if (res == null)
                {
                    MessageBox.Show($"data tidak ditemukan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _searchResult.Add(res);
                dataGridView1.DataSource = _searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAddGudang_Click(object sender, EventArgs e)
        {
            AddGudangForm addGudangForm = new AddGudangForm();
            addGudangForm.Show();
        }
    }
}
