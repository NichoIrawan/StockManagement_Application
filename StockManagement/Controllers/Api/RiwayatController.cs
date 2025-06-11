using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagement.Controllers.Api
{
    public class RiwayatController
    {
        private readonly HttpClient _client;

        public RiwayatController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        // GET /api/LaporanApi
        public async Task<List<Riwayat>> GetListBarangAsync()
        {
            try
            {
                var response = await _client.GetAsync("RiwayatApi");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<Riwayat>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<Riwayat>>(json);
                return result ?? new List<Riwayat>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<Riwayat>();
            }
        }

        // GET /api/LaporanApi/{tanggalPembuatan}
        public async Task<Riwayat> GetRiwayatgByIdAsync(DateTime tanggal)
        {
            try
            {
                var response = await _client.GetAsync($"RiwayatApi/{tanggal}");

                if (!response.IsSuccessStatusCode)
                {
                    return new Riwayat();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<Riwayat>(json);

                return result ?? new Riwayat();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new Riwayat();
            }

        }

        // POST /api/LaporanApi
        public async Task InputRiwayatAsync(Riwayat riwayat)
        {
            try
            {
                var json = JsonSerializer.Serialize(riwayat);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("RiwayatgApi", content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        // PUT /api/LaporanApi/{tanggalPembuatan}
        public async Task UpdateRiwayatAsync(DateTime tanggal, Riwayat riwayat)
        {
            try
            {
                var json = JsonSerializer.Serialize(riwayat);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PutAsync($"RiwayatApi/{tanggal}", content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        // DELETE /api/LaporanApi/{tanggalPembuatan}
        public async Task DeleteRiwayatAsync(DateTime tanggal)
        {
            try
            {
                var response = await _client.DeleteAsync($"RiwayatApi/{tanggal}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
