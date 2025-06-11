using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StockManagement.Models;
using StockManagementLibrary;

namespace StockManagement.Controllers.Api
{
    public class BarangController
    {
        private readonly HttpClient _client;

        public BarangController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        public async Task<List<Barang>> tampilkanBarang()
        {
            try
            {
                var response = await _client.GetAsync("BarangApi");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<Barang>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<Barang>>(json);
                return result ?? new List<Barang>();
            } catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<Barang>();
            }
        }


        public async Task<Barang> cariBarangDenganId(string kodeBarang)
        {
            try
            {
                var response = await _client.GetAsync($"BarangApi/{kodeBarang}");

                if (!response.IsSuccessStatusCode)
                {
                    return new Barang();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<Barang>(json);

                return result?? new Barang();
            } catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new Barang();
            }
        }

        public async Task beliBarang(Barang barang)
        {
            try
            {
                var json = JsonSerializer.Serialize(barang);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("BarangApi", content);
                response.EnsureSuccessStatusCode();
            } catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        // PUT /api/BarangApi/{kodeBarang}
        public async Task updateDataBarang(string kodeBarang, Barang barang)
        {
            var json = JsonSerializer.Serialize(barang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"BarangApi/{kodeBarang}", content);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/BarangApi/{kodeBarang}
        public async Task jualBarang(string kodeBarang)
        {
            try
            {
                var response = await _client.DeleteAsync($"BarangApi/{kodeBarang}");
                response.EnsureSuccessStatusCode();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        
    }
}
