using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagement.Controller.UserController
{
    public class AdminController
    {


        private readonly HttpClient _client;

        public AdminController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        public async Task<List<User>> GetUserList()
        {
            try
            {
                var response = await _client.GetAsync("UserApi");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<User>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<User>>(json);
                return result ?? new List<User>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<User>();
            }
        }


        public async Task<User> GetUserbyUsername(string username)
        {
            try
            {
                var response = await _client.GetAsync($"UserApi/{username}");

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<User>(json);
                

                return result ?? new User();
            }
            catch (Exception e)
            {
               
                return null;
            }
        }

        public async Task addUser(User user)
        {
            try
            {
                var json = JsonSerializer.Serialize(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("UserApi", content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        //// PUT /api/BarangApi/{kodeBarang}
        public async Task updateDataBarang(string username, User user)
        {
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"UserApi/{username}", content);
            response.EnsureSuccessStatusCode();
        }

        // DELETE /api/BarangApi/{kodeBarang}
        public async Task deleteUser(string username)
        {
            try
            {
                var response = await _client.DeleteAsync($"UserApi/{username}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }
}
