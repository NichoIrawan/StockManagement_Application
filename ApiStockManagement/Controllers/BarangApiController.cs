using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangApiController : ControllerBase
    {
        //Placholder for database context -> Will be changed
        private static List<Barang> listBarang = new List<Barang>
        {
            new Barang("001", "Barang A", "Kategori A", 10, 10000, DateOnly.FromDateTime(DateTime.Now.AddDays(30)), "G001"),
            new Barang("002", "Barang B", "Kategori B", 20, 20000, DateOnly.FromDateTime(DateTime.Now.AddDays(60)), "G002")
        };

        // GET: api/<BarangController>
        [HttpGet]
        public IEnumerable<Barang> Get()
        {
            return listBarang;
        }

        // GET api/<BarangController>/5
        [HttpGet("{id}")]
        public Barang Get(int id)
        {
            return listBarang.ElementAt(id);
        }

        // POST api/<BarangController>
        [HttpPost]
        public void Post([FromBody]Barang newBarang)
        {
            listBarang.Add(newBarang);
        }

        // PUT api/<BarangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Barang newbarang)
        {
            Barang barang = listBarang.ElementAt(id);

            if (barang == null)
            {
                return;
            }

            barang.kodeBarang = newbarang.kodeBarang;
            barang.namaBarang = newbarang.namaBarang;
            barang.kategori = newbarang.kategori;
            barang.stok = newbarang.stok;
            barang.harga = newbarang.harga;
            barang.tanggalKadaluarsa = newbarang.tanggalKadaluarsa;
            barang.kodeGudang = newbarang.kodeGudang;
        }

        // DELETE api/<BarangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                listBarang.RemoveAt(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Barang tidak ditemukan");
            }
        }
    }
}
