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
            { "1", () => Console.WriteLine("Fitur Admin - Lihat Barang") },
            { "2", () => Console.WriteLine("Fitur Admin - Insert Barang") },
            { "3", () => Console.WriteLine("Fitur Admin - Delete Barang") },
            { "4", () => Console.WriteLine("Fitur Admin - Edit Barang") },
            { "5", () => Console.WriteLine("Fitur Admin - Lihat Laporan") },
        };

            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Admin");
                Console.WriteLine("1. Lihat Barang");
                Console.WriteLine("2. Insert Barang");
                Console.WriteLine("3. Delete Barang");
                Console.WriteLine("4. Edit Barang");
                Console.WriteLine("5. Lihat Laporan");
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
