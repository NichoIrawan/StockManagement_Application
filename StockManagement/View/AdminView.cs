using StockManagement.Controller;
using StockManagement.Controller.UserController;
using StockManagement.Controllers;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.View
{
    class AdminView
    {
        BarangController barangController = new BarangController();
        LaporanController laporanController = new LaporanController();

        public StartupView startView = new StartupView();

        public AdminView(AdminController admin) { }

        public void callMenu()
        {
            var menuActions = new Dictionary<string, Action>
        {
            { "1", async() =>
                {
                    var listBarang = await barangController.tampilkanBarang();
                    foreach (var barang in listBarang)
                    {
                        Console.WriteLine($"Kode Barang: {barang.kodeBarang} \t Nama Barang: {barang.namaBarang} \t Stok: {barang.stok} \t Expired: {barang.tanggalKadaluarsa}");
                    }
                }
            },
            { "2", async () => 
                {
                    Barang barang = new Barang();

                    barang.kodeBarang = Console.ReadLine();
                    barang.namaBarang = Console.ReadLine();
                    barang.stok = int.Parse(Console.ReadLine());
                    barang.harga = double.Parse(Console.ReadLine());
                    barang.kodeGudang = Console.ReadLine();
                    barang.tanggalKadaluarsa = DateOnly.FromDateTime(DateTime.Now.AddMonths(6));

                    await barangController.beliBarang(barang);
                }    
            },
            { "3", async () => 
                {
                    string kodeBarang = Console.ReadLine();

                    await barangController.jualBarang(kodeBarang);
                } 
            },
            { "4", async () => 
                {
                    string kodeBarang = Console.ReadLine();

                    var barang = await barangController.cariBarangDenganId(kodeBarang);

                    if (barang == null)
                    {
                        Console.WriteLine("[Error] Barang tidak ada");
                    }
                    else
                    {
                        barang.namaBarang = Console.ReadLine();
                        barang.stok = int.Parse(Console.ReadLine());
                        barang.harga = double.Parse(Console.ReadLine());
                        barang.kodeGudang = Console.ReadLine();
                        barang.tanggalKadaluarsa = DateOnly.FromDateTime(DateTime.Now.AddMonths(6));

                        await barangController.updateDataBarang(barang.kodeBarang, barang);
                    }
                }  
            },
            { "5", async () =>
                {
                    var listLaporan = await laporanController.GetListLaporanAsync();
                    foreach (var laporan in listLaporan)
                    {
                        Console.WriteLine(laporan);
                    }
                } 
            },
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
