using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    class Riwayat
    {
        public int id_riwayat { get; set; }
        public DateTime tanggal { get; set; }
        public String jenis_transaksi { get; set; }
        public Barang barang { get; set; }
        public int jumlah_barang { get; set; }
        public Gudang lokasi_penyimpanan { get; set; }
        public User pic { get; set; }
    }
}
