using StockManagement.Controllers;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Controller
{
    class RiwayatController
    {
        private readonly HttpClient _client;

        public RiwayatController()
        {
            var api = new ApiClient();
            _client = api.Client;
        }

        // GET /api/LaporanApi
        public async Task<List<Riwayat>> GetListBarangAsync()
        {
            return await _client.GetFromJsonAsync<List<Riwayat>>("api/RiwayatApi").ConfigureAwait(false);
        }

        // GET /api/LaporanApi/{tanggalPembuatan}
        public async Task<Riwayat> GetBarangByIdAsync(DateTime tanggal)
        {
            var response = await _client.GetAsync($"/api/RiwayatApi/{tanggal}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Riwayat>();
            }
            return null;
        }

        // POST /api/LaporanApi
        public async Task InputRiwayatAsync(Riwayat riwayat)
        {
            var response = await _client.PostAsJsonAsync("/api/RiwayatApi", riwayat);
            response.EnsureSuccessStatusCode();
        }
    }
}
