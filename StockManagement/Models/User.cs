using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models
{
    public class User
    {
        public enum Roles { Manager, Admin, Staff }
        public string Username { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; }
        public string Password { get; set; }

        public User() {}

        public User(string username, string name, Roles role, string password)
        {
            this.Username = username;
            this.Name = name;
            this.Role = role;
            this.Password = password;
        }
    }
}
