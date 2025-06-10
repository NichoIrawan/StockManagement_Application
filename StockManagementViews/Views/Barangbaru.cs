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
        private readonly BarangController barangCont;
        private RiwayatController riwayatController = new RiwayatController();
        private GudangController gudangController = new GudangController();
        public Barangbaru()
        {
            InitializeComponent();
            barangCont = new BarangController();
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

            Barang newBarang = new Barang
            {
                kodeBarang = txtKode.Text,
                namaBarang = txtNama.Text,
                stok = int.Parse(txtStok.Text),
                harga = double.Parse(txtHarga.Text),
                tanggalKadaluarsa = DateOnly.FromDateTime(dtpKadaluarsa.Value),
                kodeGudang = txtKodeGudang.Text
            };

            User dummyUser = new User("Dummy Username", "Dummy", StockManagementLibrary.Roles.MANAGER, "123");

            try
            {
                await barangCont.beliBarang(newBarang);
                Gudang curGudang = await gudangController.GetGudangByIdAsync(txtKodeGudang.Text);
                BarangMasuk(newBarang, int.Parse(txtStok.Text), curGudang, dummyUser);
                MessageBox.Show("Barang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        private void Barangbaru_Load(object sender, EventArgs e)
        {

        }
    }
}
