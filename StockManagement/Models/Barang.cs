using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Barang
    {
        public String? kodeBarang { get; set; }
        public String? namaBarang { get; set; }
        public Kategori? kategori { get; set; }
        public int stok { get; set; }
        public double harga { get; set; }
        public DateOnly? tanggalKadaluarsa { get; set; }
        public String? kodeGudang { get; set; }
        public Gudang? gudang { get; set; }

        public Barang()
        {
            this.stok = 0;
            this.harga = 0;
        }

        public Barang(string kodeBarang, string namaBarang, Kategori kategori, int stok, double harga, DateOnly tanggalKadaluarsa, string kodeGudang)
        {
            this.kodeBarang = kodeBarang;
            this.namaBarang = namaBarang;
            this.kategori = kategori;
            this.stok = stok;
            this.harga = harga;
            this.tanggalKadaluarsa = tanggalKadaluarsa;
            this.kodeGudang = kodeGudang;
        }
    }
}
