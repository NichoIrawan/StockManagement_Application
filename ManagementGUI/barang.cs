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

namespace ManagementGUI
{
    public partial class barang : Form
    {
        private List<Barang> daftarBarang = new List<Barang>();

        public barang()
        {
            InitializeComponent();
            MuatDataAwal();
            TampilkanBarang();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang
            {
                kodeBarang = txtKode.Text,
                namaBarang = txtNama.Text,
                stok = int.Parse(txtStok.Text),
                harga = double.Parse(txtHarga.Text),
                tanggalKadaluarsa = DateOnly.FromDateTime(dtpKadaluarsa.Value),
                kodeGudang = txtKodeGudang.Text
            };

            daftarBarang.Add(barang);
            TampilkanBarang();
            BersihkanForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dgvBarang.CurrentRow.Index;
            daftarBarang[index].kodeBarang = txtKode.Text;
            daftarBarang[index].namaBarang = txtNama.Text;
            daftarBarang[index].stok = int.Parse(txtStok.Text);
            daftarBarang[index].harga = double.Parse(txtHarga.Text);
            daftarBarang[index].tanggalKadaluarsa = DateOnly.FromDateTime(dtpKadaluarsa.Value);
            daftarBarang[index].kodeGudang = txtKodeGudang.Text;

            TampilkanBarang();
            BersihkanForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvBarang.CurrentRow != null)
            {
                int index = dgvBarang.CurrentRow.Index;
                daftarBarang.RemoveAt(index);
                TampilkanBarang();
                BersihkanForm();
            }
        }

        private void MuatDataAwal()
        {
            daftarBarang.Add(new Barang
            {
                kodeBarang = "BRG001",
                namaBarang = "Sabun Mandi",
                stok = 25,
                harga = 7500,
                tanggalKadaluarsa = DateOnly.FromDateTime(DateTime.Today.AddMonths(6)),
                kodeGudang = "GD001"
            });

            daftarBarang.Add(new Barang
            {
                kodeBarang = "BRG002",
                namaBarang = "Minyak Goreng",
                stok = 40,
                harga = 14500,
                tanggalKadaluarsa = DateOnly.FromDateTime(DateTime.Today.AddMonths(4)),
                kodeGudang = "GD002"
            });
        }

        private void TampilkanBarang()
        {
            dgvBarang.DataSource = null;
            dgvBarang.DataSource = daftarBarang;

            if (dgvBarang.Columns["kategori"] != null)
                dgvBarang.Columns["kategori"].Visible = false;

            if (dgvBarang.Columns["gudang"] != null)
                dgvBarang.Columns["gudang"].Visible = false;
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Barang barang = daftarBarang[e.RowIndex];
                txtKode.Text = barang.kodeBarang;
                txtNama.Text = barang.namaBarang;
                txtStok.Text = barang.stok.ToString();
                txtHarga.Text = barang.harga.ToString();
                dtpKadaluarsa.Value = barang.tanggalKadaluarsa?.ToDateTime(TimeOnly.MinValue) ?? DateTime.Today;
                txtKodeGudang.Text = barang.kodeGudang;
            }
        }

        private void BersihkanForm()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtStok.Clear();
            txtHarga.Clear();
            txtKodeGudang.Clear();
            dtpKadaluarsa.Value = DateTime.Today;
        }
    }
}
