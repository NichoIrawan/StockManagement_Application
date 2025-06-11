using StockManagement.Controllers.Api;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Controllers
{
    public class LoginController
    {
        private readonly UserController _apiController = new();

        public async Task<Roles> Login(string username, string password)
        {
            try
            {
                User? user = await _apiController.GetUserByUsernameAsync(username);

                if (user==null)
                {
                    return Roles.USER;
                }

                if (!user.password.Equals(password))
                {
                    return Roles.USER;
                }

                return user.role;
            }
            catch
            {
                return Roles.USER;
            }
        }
    }
}
