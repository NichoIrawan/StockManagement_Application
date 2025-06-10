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
        private GudangController gudangController = new();
        private List<Gudang> listGudang = new List<Gudang>();
        private List<Gudang> searchResult = new List<Gudang>();

        public GudangHome()
        {
            InitializeComponent();
        }

        private async void GudangHome_Load(object sender, EventArgs e)
        {
            await LoadDataGudangAsync();
            dataGridView1.DataSource = listGudang;
        }

        private async Task LoadDataGudangAsync()
        {
            listGudang = await gudangController.GetListGudangAsync();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listGudang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGudangForm addGudangForm = new AddGudangForm();
            addGudangForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataGudangAsync();
        }


        private async void button4_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            dataGridView1.DataSource = null;
            searchResult.Clear();
            try
            {
                var res = await gudangController.GetGudangByIdAsync(search);
                if (res == null)
                {
                    MessageBox.Show($"data tidak ditemukan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                searchResult.Add(res);
                dataGridView1.DataSource = searchResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < listGudang.Count)
                {
                    var result = MessageBox.Show("Yakin mau hapus gudang ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string idToDelete = listGudang[e.RowIndex].kodeGudang; // Pastikan Id property bener

                        await gudangController.DeleteGudangAsync(idToDelete);
                        listGudang.RemoveAt(e.RowIndex);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listGudang;
                        MessageBox.Show("Gudang berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
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
