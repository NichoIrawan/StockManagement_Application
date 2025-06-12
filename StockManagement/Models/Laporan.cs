using StockManagement.Controllers.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockManagement.Models
{
    public class Laporan
    {
        private BarangController _controller = new();

        public DateOnly TanggalPembuatan { get; set; }
        public string TempatPenyimpanan { get; set; }
        public List<Barang> DaftarBarang { get; set; }

        public Laporan()
        {
            TanggalPembuatan = DateOnly.FromDateTime(DateTime.Now);
            TempatPenyimpanan = "G001";
            DaftarBarang = _controller.tampilkanBarang().Result;
        }
    }
}
