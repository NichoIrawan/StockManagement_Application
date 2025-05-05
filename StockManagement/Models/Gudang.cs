using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Gudang
    {
        public string? kodeGudang { get; set; }
        public  string? namaGudang { get; set; }
        public string? lokasi { get; set; }

        public Gudang() {}

        public Gudang(string kodeGudang, string namaGudang, string lokasi)
        {
            this.kodeGudang = kodeGudang;
            this.namaGudang = namaGudang;
            this.lokasi = lokasi;
        }
    }
}
