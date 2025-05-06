using StockManagement.Controllers;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagement.Controller
{
    class GudangController
    {
        private readonly HttpClient _client;

        public GudangController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        // GET /api/GudangApi
        public async Task<List<Gudang>> GetListGudangAsync()
        {
            try
            {
                var response = await _client.GetAsync("BarangApi");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<Gudang>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<Gudang>>(json);
                return result ?? new List<Gudang>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<Gudang>();
            }
        }

        // GET /api/GudangApi/{kodeBarang}
        //public async Task<Gudang>> GetListBarangById(string kodeGudang)
        //{
        //    try
        //    {
        //        var response = await _client.GetAsync($"GudangApi/{kodeGudang}");

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Gudang();
        //        }

        //        var json = await response.Content.ReadAsStringAsync();

        //        var result = JsonSerializer.Deserialize<Gudang>(json);

        //        return result ?? new Gudang();  
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Error: {e.Message}");
        //        return new Gudang();
        //    }
        //}

        // GET /api/GudangApi/{kodeBarang}
        public async Task<Gudang> GetGudangByIdAsync(string kodeGudang)
        {
            try
            {
                var response = await _client.GetAsync($"GudangApi/{kodeGudang}");

                if (!response.IsSuccessStatusCode)
                {
                    return new Gudang();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<Gudang>(json);

                return result ?? new Gudang();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new Gudang();
            }
        }

        // POST /api/GudangApi
        public async Task InputGudangAsync(Gudang gudang)
        {
            try
            {
                var json = JsonSerializer.Serialize(gudang);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("GudangApi", content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        // PUT /api/GudangApi/{kodeBarang}
        public async Task UpdateGudangAsync(string kodeGudang, Gudang gudang)
        {
            var json = JsonSerializer.Serialize(gudang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"BarangApi/{kodeGudang}", content);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/GudangApi/{kodeBarang}
        public async Task DeleteGudangAsync(string kodeGudang)
        {
            try
            {
                var response = await _client.DeleteAsync($"BarangApi/{kodeGudang}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
