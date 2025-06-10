using StockManagement.Controller;
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
            if (string.IsNullOrWhiteSpace(txtKodeGudang.Text) ||
                string.IsNullOrWhiteSpace(TxtNamaGudang.Text) ||
                string.IsNullOrWhiteSpace(TxtLokasi.Text))
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Gudang gudangBaru = new Gudang
            {
                kodeGudang = txtKodeGudang.Text.Trim(),
                namaGudang = TxtNamaGudang.Text.Trim(),
                lokasi = TxtLokasi.Text.Trim()
            };

            try
            {
                await gudangController.InputGudangAsync(gudangBaru);
                MessageBox.Show("Gudang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGudangForm_Load(object sender, EventArgs e)
        {

        }
    }

}
