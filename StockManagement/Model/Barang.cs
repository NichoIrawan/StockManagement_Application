using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    class Barang
    {
        private String kodeBarang { get; set; }
        private String namaBarang { get; set; }
        private String kategori { get; set; }
        private int stok { get; set; }
        private double harga { get; set; }
        private DateTime tanggalKadaluarsa { get; set; }

        public Barang() { }

        public Barang(string kodeBarang, string namaBarang, string kategori, int stok, double harga, DateTime tanggalKadaluarsa)
        {
            this.kodeBarang = kodeBarang;
            this.namaBarang = namaBarang;
            this.kategori = kategori;
            this.stok = stok;
            this.harga = harga;
            this.tanggalKadaluarsa = tanggalKadaluarsa;
        }
    }
}
