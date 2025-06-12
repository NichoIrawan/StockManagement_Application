using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Riwayat
    {

        public string IdRiwayat { get; set; }
        public DateTime tanggal { get; set; }
        public string jenis_transaksi { get; set; }
        public Barang barang { get; set; }
        public int jumlah_barang { get; set; }
        public Gudang lokasi_penyimpanan { get; set; }
        public User pic { get; set; }
        public Riwayat() { }
        public Riwayat(DateTime tanggal, string jenis_transaksi, Barang barang, int jumlah_barang, Gudang lokasi_penyimpanan, User pic) {
            this.IdRiwayat = $"R{tanggal.DayOfYear + tanggal.Minute + jenis_transaksi + barang.namaBarang}";
            this.tanggal = tanggal;
            this.jenis_transaksi = jenis_transaksi;
            this.barang = barang;
            this.jumlah_barang = jumlah_barang;
            this.lokasi_penyimpanan = lokasi_penyimpanan;
            this.pic = pic;
        }
    }
}
