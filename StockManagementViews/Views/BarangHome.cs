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
            try
            {
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            addBarangbaru.Show();
        }

        private async void RefreshList()
        {
            barangList.Clear();
            tableBarang.DataSource = null;
            tableBarang.Rows.Clear();
            barangList = await barangCont.tampilkanBarang();
            for (int i = 0; i < barangList.Count; i++)
            {
                int rownum = tableBarang.Rows.Add();
                tableBarang.Rows[rownum].Cells[0].Value = barangList[i].kodeBarang;
                tableBarang.Rows[rownum].Cells[1].Value = barangList[i].namaBarang;
                tableBarang.Rows[rownum].Cells[2].Value = barangList[i].stok;
                tableBarang.Rows[rownum].Cells[3].Value = barangList[i].harga;
                tableBarang.Rows[rownum].Cells[4].Value = barangList[i].tanggalKadaluarsa;
                tableBarang.Rows[rownum].Cells[5].Value = barangList[i].kodeGudang;
            }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String searchResult = searchBar.Text;
                tableBarang.DataSource = null;
                tableBarang.Rows.Clear();
                searchList.Clear();
                var res = await barangCont.cariBarangDenganId(searchResult);
                if (res == null)
                {
                    MessageBox.Show("User tidak ditemukan");
                    RefreshList();
                    return;
                }
                searchList.Add(res);
                for (int i = 0; i < searchList.Count; i++)
                {
                    int rownum = tableBarang.Rows.Add();
                    tableBarang.Rows[rownum].Cells[0].Value = barangList[i].kodeBarang;
                    tableBarang.Rows[rownum].Cells[1].Value = barangList[i].namaBarang;
                    tableBarang.Rows[rownum].Cells[2].Value = barangList[i].stok;
                    tableBarang.Rows[rownum].Cells[3].Value = barangList[i].harga;
                    tableBarang.Rows[rownum].Cells[4].Value = barangList[i].tanggalKadaluarsa;
                    tableBarang.Rows[rownum].Cells[5].Value = barangList[i].kodeGudang;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private async void TableBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = tableBarang.CurrentRow.Cells[0].Value.ToString();
            if (tableBarang.CurrentCell == tableBarang.CurrentRow.Cells[6])
            {
                await barangCont.jualBarang(username);
                tableBarang.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void TableBarang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
            if (e.ColumnIndex == 4)
            {
                e.Cancel = true;
            }
            if (e.ColumnIndex == 5)
            {
                e.Cancel = true;
            }
        }

        private async void TableBarang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow newRow = tableBarang.Rows[e.RowIndex];
            string kodeBarang = tableBarang.CurrentRow.Cells[0].Value.ToString();

            var res = await barangCont.cariBarangDenganId(kodeBarang);

            Barang newBarang = new Barang
            {
                kodeBarang = res.kodeBarang,
                namaBarang = newRow.Cells[1].Value.ToString(),
                stok = int.Parse(newRow.Cells[2].Value.ToString()),
                harga = double.Parse(newRow.Cells[3].Value.ToString()),
                tanggalKadaluarsa = res.tanggalKadaluarsa,
                kodeGudang = res.kodeGudang
            };



            await barangCont.updateDataBarang(kodeBarang, newBarang);
        }
    }
}
