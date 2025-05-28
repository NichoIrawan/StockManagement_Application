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
    public class LaporanController
    {
        private readonly HttpClient _client;

        public LaporanController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        // GET /api/LaporanApi
        public async Task<List<Laporan>> GetListLaporanAsync()
        {
            try
            {
                var response = await _client.GetAsync("LaporanApi");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<Laporan>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<Laporan>>(json);
                return result ?? new List<Laporan>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<Laporan>();
            }
        }

        // GET /api/LaporanApi/{tanggalPembuatan}
        public async Task<Laporan> GetLaporanByIdAsync(DateTime tanggalPembuatan)
        {
            try
            {
                var response = await _client.GetAsync($"LaporanApi/{tanggalPembuatan}");

                if (!response.IsSuccessStatusCode)
                {
                    return new Laporan();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<Laporan>(json);

                return result ?? new Laporan();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new Laporan();
            }
        }

        // POST /api/LaporanApi
        public async Task InputLaporanAsync(Gudang gudang)
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

        // PUT /api/LaporanApi/{kodeLaporan}
        public async Task UpdateLaporanAsync(DateTime tanggalPembuatan, Laporan laporan)
        {
            var json = JsonSerializer.Serialize(laporan);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"LaporanApi/{tanggalPembuatan}", content);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/LaporanApi/{kodeLaporan}
        public async Task DeleteLaporan(DateTime tanggalPembuatan)
        {
            try
            {
                var response = await _client.DeleteAsync($"LaporanApi/ {tanggalPembuatan}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }
}
