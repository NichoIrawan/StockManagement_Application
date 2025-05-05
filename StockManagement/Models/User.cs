using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementLibrary;

namespace StockManagement.Models
{
    public class User
    {
        public string? username { get; set; }
        public string? name { get; set; }
        public Roles? role { get; set; }
        public string? password { get; set; }

        public User() { }
   
        public User(string username, string name, Roles role, string password)
        {
            this.username = username;
            this.name = name;
            this.role = role;
            this.password = password;
        }
    }
}
