using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class Gudang
    {
        public string? KodeGudang { get; set; }
        public  string? NamaGudang { get; set; }
        public string? Lokasi { get; set; }

        public Gudang() {}

        public Gudang(string kodeGudang, string namaGudang, string lokasi)
        {
            this.KodeGudang = kodeGudang;
            this.NamaGudang = namaGudang;
            this.Lokasi = lokasi;
        }
    }
}
