using StockManagement.Controllers.Api;
using StockManagement.Models;
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

        public bool Login(string username, string password)
        {
            User? user = _apiController.GetUserByUsernameAsync(username).Result;

            if (user==null)
            {
                return false;
            }

            if (!user.password.Equals(password))
            {
                return false;
            }

            return true;
        }
    }
}
