using StockManagement.Controllers.UserController;
using StockManagement.Models;
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
                Console.WriteLine("Masukkan Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Masukkan Password:");
                string password = Console.ReadLine();

                User foundUser = userList.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
                Console.WriteLine("Username: " + foundUser.Username + "Password: " + foundUser.Password);
                if (foundUser != null)
                {
                    cont.ChangeState(
                        foundUser.Role == User.Roles.Staff ? 1 :
                        foundUser.Role == User.Roles.Manager ? 2 :
                        3);
                }
                else {
                    Console.WriteLine("Password atau User salah");
                    callMenu();
                }
                

            }
            else if (input == "2")
            {
                Console.WriteLine("Masukkan Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Masukkan Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Masukkan Password:");
                string password = Console.ReadLine();
                Console.WriteLine("Masukkan Role(1: Staff, 2: Manager, 3: Admin): ");
                string role = Console.ReadLine();
                User newUser = new User(username, name,
                    role == "1" ? User.Roles.Staff :
                    role == "2" ? User.Roles.Manager :
                    User.Roles.Admin,
                    password);
                userList.Add(newUser);
                callMenu();

            }
        }

    }
}
