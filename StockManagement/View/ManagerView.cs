using StockManagement.Controller;
using StockManagement.Controller.UserController;
using StockManagement.Controllers;
using StockManagement.Models;
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
        BarangController barangController = new BarangController();
        LaporanController laporanController = new LaporanController();
        GudangController gudangController = new GudangController();

        public StartupView startView = new StartupView();

        public ManagerView(ManagerController manager) { }

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
            { "4", async () =>
                {
                    string kodeBarang = Console.ReadLine();

                    await barangController.jualBarang(kodeBarang);
                }
            },
            { "5", async() =>
                {
                    var listGudang = await gudangController.GetListGudangAsync();
                    foreach (var gudang in listGudang)
                    {
                        Console.WriteLine($"Kode Gudang: {gudang.kodeGudang} \t Nama Gudang: {gudang.namaGudang} \t Alamat: {gudang.lokasi}");
                    }
                }
            },
            { "6", async () =>
                {
                    Gudang gudang = new Gudang();

                    gudang.kodeGudang = Console.ReadLine();
                    gudang.namaGudang = Console.ReadLine();
                    gudang.lokasi = Console.ReadLine();

                    await gudangController.InputGudangAsync(gudang);
                }
            },
            { "7", async () =>
                {
                    string kodeGudang = Console.ReadLine();

                    var gudang = await gudangController.GetGudangByIdAsync(kodeGudang);

                    if (gudang == null)
                    {
                        Console.WriteLine("[Error] Gudang tidak ada");
                    }
                    else
                    {
                        gudang.namaGudang = Console.ReadLine();
                        gudang.lokasi = Console.ReadLine();

                        await gudangController.UpdateGudangAsync(gudang.kodeGudang, gudang);
                    }
                }
            },
            { "8", async () =>
                {
                    string kodeGudang = Console.ReadLine();

                    await gudangController.DeleteGudangAsync(kodeGudang);
                }
            },
            { "9", async () =>
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
                Console.WriteLine("Selamat datang di menu Manager");
                Console.WriteLine("1. Lihat list barang");
                Console.WriteLine("2. Tambah barang");
                Console.WriteLine("3. Edit barang");
                Console.WriteLine("4. Hapus barang");
                Console.WriteLine("5. Lihat list gudang");
                Console.WriteLine("6. Tambah gudang");
                Console.WriteLine("7. Edit gudang");
                Console.WriteLine("8. Hapus gudang");
                Console.WriteLine("9. Lihat Riwayat");
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
