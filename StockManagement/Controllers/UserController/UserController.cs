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

namespace StockManagement.UControllers.UserController
{
    public class UserController
    {
        private readonly HttpClient _client;

        public UserController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5052/api/");
        }

        public async Task<List<User>> GetUsersAsync()
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

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            try
            {
                var response = await _client.GetAsync($"UserApi/{username}");

                if (!response.IsSuccessStatusCode)
                {
                    return new();
                }

                var json = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<User>(json);

                return result ?? new();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new();
            }
        }

        public async Task PostUserAsync(User user)
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

        public async Task UpdateUserDataAsync(string username, User user)
        {
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"UserApi/{username}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteUserAsync(string username)
        {
            try
            {
                var response = await _client.DeleteAsync($"UserApi/ {username}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
