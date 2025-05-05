using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Controller
{
    class LaporanController
    {
        public class LaporanController
        {
            private List<Laporan> daftarLaporan = new List<Laporan>();

            public List<Laporan> GetSemuaLaporan()
            {
                return daftarLaporan;
            }

            public Laporan GetLaporanById(int id)
            {
                if (id >= 0 && id < daftarLaporan.Count)
                {
                    return daftarLaporan[id];
                }
                else
                {
                    Console.WriteLine("Laporan tidak ditemukan.");
                    return null;
                }
            }

            public bool TambahLaporan(Laporan laporanBaru)
            {
                if (!LaporanHelper.IsValid(laporanBaru))
                {
                    Console.WriteLine("Laporan tidak valid.");
                    return false;
                }

                daftarLaporan.Add(laporanBaru);
                Console.WriteLine("Laporan berhasil ditambahkan.");
                return true;
            }

            public bool UpdateLaporan(int id, Laporan laporanBaru)
            {
                if (id < 0 || id >= daftarLaporan.Count)
                {
                    Console.WriteLine("Laporan tidak ditemukan.");
                    return false;
                }

                if (!LaporanHelper.IsValid(laporanBaru))
                {
                    Console.WriteLine("Data baru tidak valid.");
                    return false;
                }

                LaporanHelper.CopyData(daftarLaporan[id], laporanBaru);
                Console.WriteLine("Laporan berhasil diperbarui.");
                return true;
            }

            public bool HapusLaporan(int id)
            {
                if (id >= 0 && id < daftarLaporan.Count)
                {
                    daftarLaporan.RemoveAt(id);
                    Console.WriteLine("Laporan berhasil dihapus.");
                    return true;
                }

                Console.WriteLine("Laporan tidak ditemukan.");
                return false;
            }
        }

        public static class LaporanHelper
        {
            public static bool IsValid(Laporan laporan)
            {
                return laporan != null && laporan.tempatPenyimpanan != null && laporan.daftarBarang != null;
            }

            public static void CopyData(Laporan target, Laporan source)
            {
                target.tanggalPembuatan = source.tanggalPembuatan;
                target.tempatPenyimpanan = source.tempatPenyimpanan;
                target.daftarBarang = source.daftarBarang;
            }
        }
    }
