using StockManagement.Controller;
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
    public partial class Barangbaru : Form
    {
        private readonly BarangController BarangController;

        public Barangbaru()
        {
            InitializeComponent();
            BarangController = new BarangController();
        }

        private async void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKode.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                string.IsNullOrWhiteSpace(txtKodeGudang.Text))
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Barang Barangbaru = new Barang
            {
                kodeBarang = txtKode.Text,
                namaBarang = txtNama.Text,
                stok = int.Parse(txtStok.Text),
                harga = double.Parse(txtHarga.Text),
                tanggalKadaluarsa = DateOnly.FromDateTime(dtpKadaluarsa.Value),
                kodeGudang = txtKodeGudang.Text
            };

            try
            {
                await BarangController.InputBarangAsync(Barangbaru);
                MessageBox.Show("Barang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
