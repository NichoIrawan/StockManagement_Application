using StockManagement.Controller.UserController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.View
{
    class AdminView
    {
        public StartupView startView = new StartupView();

        public AdminView(AdminController admin) { }

        public void callMenu()
        {
            var menuActions = new Dictionary<string, Action>
        {
            { "1", () => Console.WriteLine("Fitur Admin - Lihat Barang") }
        };

            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Admin");
                Console.WriteLine("1. Fitur admin");
                Console.WriteLine("0. Keluar\n");
                input = Console.ReadLine();

                if (input == "0") break;

                if (menuActions.ContainsKey(input))
                    menuActions[input].Invoke();
                else
                    Console.WriteLine("Pilihan tidak valid.");
            } while (true);

            startView.callMenu();
        }
    }
}
