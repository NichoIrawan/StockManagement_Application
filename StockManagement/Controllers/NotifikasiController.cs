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
            CheckStock, CheckExpired, Selesai
        }

        private readonly Dictionary<State, Func<List<Barang>, List<string>>> StateActions;
        private readonly Notifikasi notif = new Notifikasi();
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5052/api/BarangApi"; // Adjust as needed

        public NotifikasiController()
        {
            _httpClient = new HttpClient();
            StateActions = new Dictionary<State, Func<List<Barang>, List<string>>>
            {
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

        public List<string> ProcessNotification(List<Barang> stokSekarang)
        {
            var hasil = new List<string>();
            var state = State.CheckStock;

            while (state != State.Selesai)
            {
                if (StateActions.TryGetValue(state, out var action))
                    hasil.AddRange(action(stokSekarang));

                state = state switch
                {
                    State.CheckStock => State.CheckExpired,
                    _ => State.Selesai
                };
            }

            return hasil;
        }

        private List<string> OutOfStockItem(List<Barang> stok) =>
            stok.Where(b => b.stok == 0)
                .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.habis)}")
                .ToList();

        private List<string> ExpiredStock(List<Barang> stok)
        {
            DateOnly hariIni = DateOnly.FromDateTime(DateTime.Now);
            DateOnly batas = hariIni.AddDays(7);

            return stok.Where(b => b.tanggalKadaluarsa.HasValue &&
                                   b.tanggalKadaluarsa.Value <= batas)
                       .Select(b => $"{b.namaBarang} - {notif.ReadNotif(Notifikasi.notifApp.kadaluarsa)}")
                       .ToList();
        }
    }
}
