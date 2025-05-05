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
    class GudangController
    {
        private readonly HttpClient _client;

        public GudangController()
        {
            var api = new ApiClient();
            _client = api.Client;
        }

        // GET /api/GudangApi
        public async Task<List<Gudang>> GetListBarangAsync()
        {
            return await _client.GetFromJsonAsync<List<Gudang>>("api/GudangApi").ConfigureAwait(false);
        }

        public async Task<List<Gudang>> GetListBarangByIdAsync(string kodeGudang)
        {
            return await _client.GetFromJsonAsync<List<Gudang>>($"api/GudangApi/{kodeGudang}").ConfigureAwait(false);
        }

        // GET /api/GudangApi/{kodeBarang}
        public async Task<Gudang> GetBarangByIdAsync(string kodeGudang)
        {
            var response = await _client.GetAsync($"/api/GudangApi/{kodeGudang}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Gudang>();
            }
            return null;
        }

        // POST /api/GudangApi
        public async Task InputGudangAsync(Gudang gudang)
        {
            var response = await _client.PostAsJsonAsync("/api/GudangApi", gudang);
            response.EnsureSuccessStatusCode();
        }

        // PUT /api/GudangApi/{kodeBarang}
        public async Task UpdateGudangAsync(string kodeGudang, Gudang gudang)
        {
            var response = await _client.PutAsJsonAsync($"/api/GudangApi/{kodeGudang}", gudang);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/GudangApi/{kodeBarang}
        public async Task DeleteGudangAsync(string kodeGudang)
        {
            var response = await _client.DeleteAsync($"/api/GudangApi/{kodeGudang}");
            response.EnsureSuccessStatusCode();
        }
    }
}
