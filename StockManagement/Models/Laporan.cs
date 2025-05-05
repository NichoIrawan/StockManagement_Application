using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockManagement.Models
{
    public class Laporan
    {
        public DateTime tanggalPembuatan { get; set; }
        public Gudang tempatPenyimpanan { get; set; }
        public List<Barang> daftarBarang { get; set; }

        public Laporan()
        {
            daftarBarang = new List<Barang>();
        }

        public Laporan(DateTime tanggal, Gudang penyimpanan, List<Barang> daftar) 
        {
            this.tanggalPembuatan = tanggal;
            this.tempatPenyimpanan = penyimpanan;
            this.daftarBarang = daftar;
        }
        
 /*       public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Tanggal Pembuatan : {tanggalPembuatan}");
            sb.AppendLine($"Tempat Penyimpanan: {tempatPenyimpanan.namaGudang} - {tempatPenyimpanan.lokasi}");

            sb.AppendLine("Daftar Barang:");
            foreach (var barang in daftarBarang)
            {
                sb.AppendLine($" - {barang.namaBarang} (Kode: {barang.kodeBarang}), Kategori: {barang.kategori}, Jumlah: {barang.jumlah}, Harga: {barang.harga}, Kadaluarsa: {barang.tanggalKadaluarsa}");
            }

            return sb.ToString();
        }*/
    }
}
