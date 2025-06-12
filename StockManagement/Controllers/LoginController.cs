using StockManagement.Controllers.Api;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StockManagement.Controllers
{
    public class LoginController
    {
        private readonly UserController _apiController = new();

        public async Task<User> Login(string username, string password)
        {
            try
            {
                if (!ValidateInput(username) && !ValidateInput(password))
                {
                    return new();
                }

                User? user = await _apiController.GetUserByUsernameAsync(username);

                if (user == null)
                {
                    return new();
                }

                if (!user.password.Equals(password))
                {
                    return new();
                }

                return user;
            }
            catch (Exception e)
            {
                throw new Exception($"Login failed: {e.Message}");
            }
        }

        private static bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Semua data harus diisi!");
            }

            if (!IsValidText(input))
            {
                throw new Exception("Input mengandung karakter tidak diizinkan.");
            }

            return true;
        }

        private static bool IsValidText(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }
    }
}
