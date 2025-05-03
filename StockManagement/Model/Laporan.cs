using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    class Laporan
    {
        public DateTime tanggalPembuatan { get; set; }
        public Gudang tempatPenyimpanan { get; set; }
        public List<Barang> daftarBarang { get; set; }

        public Laporan(DateTime tanggal, Gudang penyimpanan, List<Barang> daftar) 
        {
            this.tanggalPembuatan = tanggal;
            this.tempatPenyimpanan = penyimpanan;
            this.daftarBarang = daftar;
        }
        
    }
}
