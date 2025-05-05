using StockManagement.Controller.UserController;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Controller
{
    class NotifikasiController
    {
        public enum State
        {
            CekMasuk, CekKeluar, CekStok, CekExpired, Selesai
        }

        private readonly Dictionary<State, Func<List<Barang>, List<Barang>, List<string>>> stateActions;
        private readonly Notifikasi notif = new Notifikasi();

        public NotifikasiController()
        {
            stateActions = new Dictionary<State, Func<List<Barang>, List<Barang>, List<string>>>
            {
                { State.CekMasuk, BarangMasuk },
                { State.CekKeluar, BarangKeluar },
                { State.CekStok, BarangHabis },
                { State.CekExpired, BarangExpired }
            };
        }

        public void TampilkanNotifikasi(List<Barang> stokSebelumnya, List<Barang> stokSekarang)
        {
            var hasil = ProsesNotifikasi(stokSekarang, stokSebelumnya);

            Console.WriteLine("=== Notifikasi ===");
            foreach (var h in hasil)
            {
                Console.WriteLine(h);
            }
        }

        public List<string> ProsesNotifikasi(List<Barang> terbaru, List<Barang> sebelumnya)
        {
            var hasil = new List<string>();
            var state = State.CekMasuk;

            while (state != State.Selesai)
            {
                if (stateActions.TryGetValue(state, out var action))
                    hasil.AddRange(action(terbaru, sebelumnya));

                state = state switch
                {
                    State.CekMasuk => State.CekKeluar,
                    State.CekKeluar => State.CekStok,
                    State.CekStok => State.CekExpired,
                    _ => State.Selesai
                };
            }

            return hasil;
        }

        private List<string> BarangMasuk(List<Barang> baru, List<Barang> lama) =>
            baru.Where(b => lama.Any(l => l.kodeBarang == b.kodeBarang && b.stok > l.stok))
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.masuk)}")
                .ToList();

        private List<string> BarangKeluar(List<Barang> baru, List<Barang> lama) =>
            baru.Where(b => lama.Any(l => l.kodeBarang == b.kodeBarang && b.stok < l.stok))
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.keluar)}")
                .ToList();

        private List<string> BarangHabis(List<Barang> baru, List<Barang> _) =>
            baru.Where(b => b.stok == 0)
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.habis)}")
                .ToList();

        private List<string> BarangExpired(List<Barang> baru, List<Barang> _)
        {
            DateOnly hariIni = DateOnly.FromDateTime(DateTime.Now);
            DateOnly batas = hariIni.AddDays(7);

            return baru.Where(b => b.tanggalKadaluarsa.HasValue &&
                                   b.tanggalKadaluarsa.Value <= batas)
                       .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.kadaluarsa)}")
                       .ToList();
        }
    }
}
