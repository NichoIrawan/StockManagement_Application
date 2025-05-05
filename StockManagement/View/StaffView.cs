using StockManagement.Controller.UserController;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.View
{
    public class StaffView
    {
        public StartupView startView = new StartupView();

        public StaffView(StaffController staff) { }

        public void callMenu()
        {
            var menuActions = new Dictionary<string, Action>
        {
            { "1", () => Console.WriteLine("Lihat barang") },
            { "2", () => Console.WriteLine("Tambah Barang") },
            { "3", () => Console.WriteLine("Edit Barang") },
        };

            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Staff");
                Console.WriteLine("1. Lihat list barang");
                Console.WriteLine("2. Tambah barang");
                Console.WriteLine("3. Edit barang");
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