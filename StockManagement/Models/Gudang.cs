using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Gudang
    {
        public  string? NamaGudang { get; set; }
        public string? Lokasi { get; set; }

        public Gudang() {}

        public Gudang(string namaGudang, string lokasi)
        {
            this.NamaGudang = namaGudang;
            this.Lokasi = lokasi;
        }
    }
}
