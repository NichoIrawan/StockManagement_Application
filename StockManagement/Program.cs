<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿using StockManagement.Controller;
using StockManagement.Models;
using StockManagement.View;
using StockManagementLibrary;

class main
{
    public static void Main(string[] args)
    {
        var laporanSebelumnya = new List<Barang>
        {
            new Barang { namaBarang = "Laptop", stok = 10 },
            new Barang { namaBarang = "Mouse", stok = 5 },
            new Barang { namaBarang = "Keyboard", stok = 3 }
        };

        var laporanTerbaru = new List<Barang>
        {
            new Barang { namaBarang = "Laptop", stok = 7 },
            new Barang { namaBarang = "Mouse", stok = 10 },
            new Barang { namaBarang = "Keyboard", stok = 0 },
            new Barang { namaBarang = "Monitor", stok = 4 }
        };

        var controller = new NotifikasiController();
        var hasilNotif = controller.ProsesNotifikasi(laporanTerbaru, laporanSebelumnya);

        Console.WriteLine("=== Notifikasi ===");
        foreach (var notif in hasilNotif)
        {
            Console.WriteLine(notif);
        }
        BahasaConfig bahasaConfig = new BahasaConfig();
        Console.WriteLine(Path.GetFullPath(BahasaConfig.filePath));

        StartupView startupView = new StartupView();

        startupView.callMenu();

        

    }
}
>>>>>>> Stashed changes
