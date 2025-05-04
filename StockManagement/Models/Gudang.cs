using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Gudang
    {
        public string NamaGudang { get; set; }
        public string Lokasi { get; set; }
        public List<Barang> DaftarBarang { get; set; }

        public Gudang()
        {
            DaftarBarang = new List<Barang>();
        }

        public Gudang(string namaGudang, string lokasi, List<Barang> daftarBarang)
        {
            this.NamaGudang = namaGudang;
            this.Lokasi = lokasi;
            this.DaftarBarang = daftarBarang;
        }
    }
}
