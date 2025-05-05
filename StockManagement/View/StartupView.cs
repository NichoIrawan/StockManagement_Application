using StockManagement.Controllers.UserController;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockManagement.View
{
    public class StartupView
    {
        UserStateController cont = new UserStateController();

        List<User> userList = new List<User>();
        public StartupView() {   
        }

        public void callMenu() {
      
            Console.WriteLine("Selamat Datang di Aplikasi Manajemen Inventori Supermarket A!");
            Console.WriteLine("Silahkan Login atau Register:");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("");
            LoginRegister();
            
        }

        public void LoginRegister() {
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Masukkan username:");
                string username = Console.ReadLine();
                Console.WriteLine("Masukkan password:");
                string password = Console.ReadLine();

                User foundUser = userList.FirstOrDefault(u => u.username.Equals(username) && u.password.Equals(password));
                Console.WriteLine("username: " + foundUser.username + "password: " + foundUser.password);
                if (foundUser != null)
                {
                    cont.ChangeState(
                        foundUser.role == Roles.Staff ? 1 :
                        foundUser.role == Roles.Manager ? 2 :
                        3);
                }
                else {
                    Console.WriteLine("password atau User salah");
                    callMenu();
                }
                

            }
            else if (input == "2")
            {
                Console.WriteLine("Masukkan username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Masukkan Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Masukkan password:");
                string password = Console.ReadLine();
                Console.WriteLine("Masukkan role(1: Staff, 2: Manager, 3: Admin): ");
                string role = Console.ReadLine();
                User newUser = new User(username, name,
                    role == "1" ? Roles.Staff :
                    role == "2" ? Roles.Manager :
                    Roles.Admin,
                    password);
                userList.Add(newUser);
                callMenu();

            }
        }

    }
}
