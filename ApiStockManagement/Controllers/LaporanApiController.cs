using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaporanApiController : ControllerBase
    {

        //Placeholder for database context -> Will be changed
        private static List<Laporan> listLaporan = new List<Laporan>()
{
    new Laporan(
        DateTime.Now,
        new Gudang("Gudang A", "Jakarta", new List<Barang>
        {
            new Barang("B001", "Barang 1", "Elektronik", 100, 50000, null, "G001"),
            new Barang("B002", "Barang 2", "Pakaian", 50, 75000, null, "G001")
        }),
        new List<Barang>
        {
            new Barang("B001", "Barang 1", "Elektronik", 100, 50000, null, "G001"),
            new Barang("B002", "Barang 2", "Pakaian", 50, 75000, null, "G001")
        }
    ),
    new Laporan(
        DateTime.Now.AddDays(-1),
        new Gudang("Gudang B", "Surabaya", new List<Barang>
        {
            new Barang("B003", "Barang 3", "Makanan", 200, 25000, DateOnly.FromDateTime(DateTime.Now.AddMonths(6)), "G002"),
            new Barang("B004", "Barang 4", "Minuman", 150, 15000, DateOnly.FromDateTime(DateTime.Now.AddMonths(3)), "G002")
        }),
        new List<Barang>
        {
            new Barang("B003", "Barang 3", "Makanan", 200, 25000, DateOnly.FromDateTime(DateTime.Now.AddMonths(6)), "G002"),
            new Barang("B004", "Barang 4", "Minuman", 150, 15000, DateOnly.FromDateTime(DateTime.Now.AddMonths(3)), "G002")
        }
    )
};

        // GET: api/<LaporanApiController>
        [HttpGet]
        public IEnumerable<Laporan> Get()
        {
            return listLaporan;
        }

        // GET api/<LaporanApiController>/5
        [HttpGet("{id}")]
        public Laporan Get(int id)
        {
            return listLaporan.ElementAt(id);
        }

        // POST api/<LaporanApiController>
        [HttpPost]
        public void Post([FromBody]Laporan newLaporan)
        {
            listLaporan.Add(newLaporan);
        }

        // PUT api/<LaporanApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Laporan newLaporan)
        {
            Laporan laporan = listLaporan.ElementAt(id);

            if (laporan == null)
            {
                return;
            }

            laporan.tanggalPembuatan = newLaporan.tanggalPembuatan;
            laporan.tempatPenyimpanan = newLaporan.tempatPenyimpanan;
            laporan.daftarBarang = newLaporan.daftarBarang;
        }

        // DELETE api/<LaporanApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                listLaporan.RemoveAt(id);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Laporan tidak ditemukan");
            }
        }
    }
}
