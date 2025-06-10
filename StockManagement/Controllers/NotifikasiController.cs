using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StockManagement.Models;
using System.Collections.Generic;
using System;

namespace StockManagement.Controller
{
    public class NotifikasiController
    {
        public enum State
        {
            In, Out, CheckStock, CheckExpired, Selesai
        }

        private readonly Dictionary<State, Func<List<Barang>, List<Barang>, List<string>>> StateActions;
        private readonly Notifikasi notif = new Notifikasi();
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5000/api/BarangApi"; // Adjust as needed

        public NotifikasiController()
        {
            _httpClient = new HttpClient();
            StateActions = new Dictionary<State, Func<List<Barang>, List<Barang>, List<string>>>
            {
                { State.In, IncomingStock },
                { State.Out, OutgoingStock },
                { State.CheckStock, OutOfStockItem },
                { State.CheckExpired, ExpiredStock }
            };
        }

        // Fetches the current list of Barang from the API
        public async Task<List<Barang>> GetBarangListFromApiAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Barang>>(_apiBaseUrl);
            return result ?? new List<Barang>();
        }

        // Example: Show notification using data from API
        public async Task ShowNotificationFromApiAsync(List<Barang> stokSebelumnya)
        {
            var stokSekarang = await GetBarangListFromApiAsync();
            var hasil = ProcessNotification(stokSekarang, stokSebelumnya);

            Console.WriteLine("=== Notifikasi ===");
            foreach (var h in hasil)
            {
                Console.WriteLine(h);
            }
        }

        public List<string> ProcessNotification(List<Barang> stokSekarang, List<Barang> stokSebelumnya)
        {
            var hasil = new List<string>();
            var state = State.In;

            while (state != State.Selesai)
            {
                if (StateActions.TryGetValue(state, out var action))
                    hasil.AddRange(action(stokSekarang, stokSebelumnya));

                state = state switch
                {
                    State.In => State.Out,
                    State.Out => State.CheckStock,
                    State.CheckStock => State.CheckExpired,
                    _ => State.Selesai
                };
            }

            return hasil;
        }

        private List<string> IncomingStock(List<Barang> baru, List<Barang> lama) =>
            baru.Where(b => lama.Any(l => l.kodeBarang == b.kodeBarang && b.stok > l.stok))
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.masuk)}")
                .ToList();

        private List<string> OutgoingStock(List<Barang> baru, List<Barang> lama) =>
            baru.Where(b => lama.Any(l => l.kodeBarang == b.kodeBarang && b.stok < l.stok))
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.keluar)}")
                .ToList();

        private List<string> OutOfStockItem(List<Barang> baru, List<Barang> _) =>
            baru.Where(b => b.stok == 0)
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.habis)}")
                .ToList();

        private List<string> ExpiredStock(List<Barang> baru, List<Barang> _)
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
