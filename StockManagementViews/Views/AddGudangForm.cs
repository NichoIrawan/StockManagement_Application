using StockManagement.Controller;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementViews.Views
{
    public partial class AddGudangForm : Form
    {
        private readonly GudangController gudangController;
        public AddGudangForm()
        {
            InitializeComponent();
            gudangController = new GudangController();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Ambil dan bersihkan input dari user
            string kode = txtKodeGudang.Text.Trim();
            string nama = TxtNamaGudang.Text.Trim();
            string lokasi = TxtLokasi.Text.Trim();

            // Validasi semua inputan, keluar kalau ada yang invalid
            if (!ValidateInput(kode, nama, lokasi))
                return;

            // Buat objek Gudang baru
            var gudangBaru = new Gudang
            {
                kodeGudang = kode,
                namaGudang = nama,
                lokasi = lokasi
            };

            try
            {
                // Simpan data gudang ke database lewat controller
                await gudangController.InputGudangAsync(gudangBaru);
                MessageBox.Show("Gudang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Tangani error saat penyimpanan
                ShowWarning($"Error: {ex.Message}", "Gagal", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validasi input dari form AddGudang.
        /// Mengecek apakah input kosong, terlalu panjang, atau mengandung karakter aneh.
        /// </summary>
        private bool ValidateInput(string kode, string nama, string lokasi)
        {
            if (string.IsNullOrWhiteSpace(kode) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(lokasi))
            {
                ShowWarning("Semua data harus diisi!", "Peringatan");
                return false;
            }

            if (kode.Length > 10 || nama.Length > 50 || lokasi.Length > 50)
            {
                ShowWarning("Panjang input melebihi batas maksimal.", "Peringatan");
                return false;
            }

            if (!IsValidText(kode) || !IsValidText(nama) || !IsValidText(lokasi))
            {
                ShowWarning("Input mengandung karakter tidak diizinkan.", "Peringatan");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validasi apakah input hanya mengandung karakter yang diizinkan:
        /// huruf, angka, spasi, titik, koma, garis miring, dan strip.
        /// </summary>
        private bool IsValidText(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9 .,/-]+$");
        }

        private void ShowWarning(string message, string title, MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
