using StockManagement.Controllers.UserController;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagement.View
{
    public class StartupView
    {
        UserStateController cont = new UserStateController();
        List<User> userList = new List<User>();

        public StartupView() { }

        public void callMenu()
        {
            Console.WriteLine("Selamat Datang di Aplikasi Manajemen Inventori Supermarket A!");
            Console.WriteLine("Silahkan Login atau Register:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("0. Keluar\n");

            var menuActions = new Dictionary<string, Action>
    {
        { "1", Login },
        { "2", Register },
        { "0", () => {
            Console.WriteLine("Terima kasih telah menggunakan aplikasi. Keluar...");
            Environment.Exit(0); // keluar dari aplikasi
        }}
    };

            string input = Console.ReadLine();

            if (menuActions.ContainsKey(input))
                menuActions[input].Invoke();
            else
            {
                Console.WriteLine("Pilihan tidak valid!\n");
                callMenu();
            }
        }


        private void Login()
        {
            Console.WriteLine("Masukkan username:");
            string username = Console.ReadLine();
            Console.WriteLine("Masukkan password:");
            string password = Console.ReadLine();

            User foundUser = userList.FirstOrDefault(u => u.username.Equals(username) && u.password.Equals(password));

            if (foundUser != null)
            {
                Console.WriteLine($"Login berhasil sebagai {foundUser.role}");
                cont.ChangeState(
                    foundUser.role == Roles.Staff ? 1 :
                    foundUser.role == Roles.Manager ? 2 : 3);
            }
            else
            {
                Console.WriteLine("Password atau username salah.\n");
                callMenu();
            }
        }

        private void Register()
        {
            Console.WriteLine("Masukkan username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Masukkan Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Masukkan password:");
            string password = Console.ReadLine();
            Console.WriteLine("Masukkan role (1: Staff, 2: Manager, 3: Admin): ");
            string roleInput = Console.ReadLine();

            Roles role = roleInput == "1" ? Roles.Staff :
                         roleInput == "2" ? Roles.Manager :
                         Roles.Admin;

            User newUser = new User(username, name, role, password);
            userList.Add(newUser);

            Console.WriteLine("Registrasi berhasil! Silakan login kembali.\n");
            callMenu();
        }
    }
}
