using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models;

namespace StockManagement.Controllers
{
    public class BarangController
    {
        private readonly HttpClient _client;

        public BarangController()
        {
            var api = new ApiClient();
            _client = api.Client;
        }

        // GET /api/BarangApi
        public async Task<List<Barang>> GetListBarangAsync()
        {
            return await _client.GetFromJsonAsync<List<Barang>>("api/BarangApi").ConfigureAwait(false);
        }

        // GET /api/BarangApi/{kodeBarang}
        public async Task<Barang> GetBarangByIdAsync(string kodeBarang)
        {
            var response = await _client.GetAsync($"/api/BarangApi/{kodeBarang}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Barang>();
            }
            return null;
        }

        // POST /api/BarangApi
        public async Task InputBarangAsync(Barang barang)
        {
            var response = await _client.PostAsJsonAsync("/api/BarangApi", barang);
            response.EnsureSuccessStatusCode();
        }

        // PUT /api/BarangApi/{kodeBarang}
        public async Task UpdateBarangAsync(string kodeBarang, Barang barang)
        {
            var response = await _client.PutAsJsonAsync($"/api/BarangApi/{kodeBarang}", barang);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/BarangApi/{kodeBarang}
        public async Task DeleteBarangAsync(string kodeBarang)
        {
            var response = await _client.DeleteAsync($"/api/BarangApi/{kodeBarang}");
            response.EnsureSuccessStatusCode();
        }
    }
}
