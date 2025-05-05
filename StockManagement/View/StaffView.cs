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
        public StaffView(StaffController staff) {}
       

        public void callMenu()
        {
            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Staff");
                Console.WriteLine("1. Lihat list barang");
                Console.WriteLine("2. Tambah barang");
                Console.WriteLine("3. Edit barang");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Lihat barang");
                        break;
                    case "2":
                        Console.WriteLine("Tambah Barang");
                        break;
                    case "3":
                        Console.WriteLine("Edit Barang");
                        break;
                }
            } while (input != "0");
            startView.callMenu();
            
        }

    }
}
