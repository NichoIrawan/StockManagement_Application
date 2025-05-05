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
        public AdminView(AdminController admin) {
        }

        public void callMenu()
        {
            string input;
            do
            {
                Console.WriteLine("Selamat datang di menu Admin");
                Console.WriteLine("1. Fitur admin");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Lihat barang");
                        break;
                   
                }
            } while (input != "0");
            startView.callMenu();
        }
    }
}
