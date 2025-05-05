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
    class LaporanController
    {
        private readonly HttpClient _client;

        public LaporanController()
        {
            var api = new ApiClient();
            _client = api.Client;
        }

        // GET /api/LaporanApi
        public async Task<List<Laporan>> GetListBarangAsync()
        {
            return await _client.GetFromJsonAsync<List<Laporan>>("api/LaporanApi").ConfigureAwait(false);
        }

        // GET /api/LaporanApi/{tanggalPembuatan}
        public async Task<Laporan> GetBarangByIdAsync(DateTime tanggalPembuatan)
        {
            var response = await _client.GetAsync($"/api/LaporanApi/{tanggalPembuatan}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Laporan>();
            }
            return null;
        }

        // POST /api/LaporanApi
        public async Task InputGudangAsync(Gudang gudang)
        {
            var response = await _client.PostAsJsonAsync("/api/LaporanApi", gudang);
            response.EnsureSuccessStatusCode();
        }

    }
}
