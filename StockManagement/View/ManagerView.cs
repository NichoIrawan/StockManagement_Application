using StockManagement.Controller.UserController;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.View
{
    class ManagerView
    {
        public StartupView startView = new StartupView();

        public ManagerView(ManagerController manager) { }

        public void callMenu()
        {
            var menuActions = new Dictionary<string, Action>
        {
            { "1", () => Console.WriteLine("Lihat barang") },
            { "2", () => Console.WriteLine("Tambah Barang") },
            { "3", () => Console.WriteLine("Edit Barang") },
            { "4", () => Console.WriteLine("Print Laporan barang") },
            { "5", () => Console.WriteLine("Lihat Riwayat") },
        };

            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Manager");
                Console.WriteLine("1. Lihat list barang");
                Console.WriteLine("2. Tambah barang");
                Console.WriteLine("3. Edit barang");
                Console.WriteLine("4. Print Laporan barang");
                Console.WriteLine("5. Lihat Riwayat");
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
