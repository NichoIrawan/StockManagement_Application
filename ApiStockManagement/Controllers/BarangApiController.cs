using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangApiController : ControllerBase
    {
        private static String filePath = "D:/Nicho/C# Visual Studio/StockManagement/ApiStockManagement/Data/ListBarang.json";
        private static List<Barang> listBarang;

        // GET: api/<BarangController>
        [HttpGet]
        public ActionResult<IEnumerable<Barang>> Get()
        {
            listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath);
            
            return listBarang is null? NotFound() : Ok(listBarang);
        }

        // GET api/<BarangController>/5
        [HttpGet("{kodeBarang}")]
        public ActionResult<Barang> Get(String kodeBarang)
        {
            listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath);

            if (listBarang is null)
            {
                return NotFound("Barang not found");
            }

            var barang = listBarang.FirstOrDefault(item => item.kodeBarang == kodeBarang);
            
            return barang is null? NotFound() : Ok(barang);
        }

        // POST api/<BarangController>
        [HttpPost]
        public ActionResult Post([FromBody]Barang newBarang)
        {
            listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath);

            if (newBarang == null)
            {
                return BadRequest("Barang cannot be null");
            }

            foreach (Barang barang in listBarang)
            {
                if (barang.kodeBarang == newBarang.kodeBarang)
                {
                    return BadRequest("Barang with the same code already exists");
                }
            }

            listBarang.Add(newBarang);
            JsonHandler<List<Barang>>.writeJsonToFile(filePath, listBarang);

            return CreatedAtAction(nameof(Get), new { id = newBarang.kodeBarang }, newBarang);
        }

        // PUT api/<BarangController>/5
        [HttpPut("{kodeBarang}")]
        public void Put(String kodeBarang, [FromBody]Barang newbarang)
        {
            listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath);
            var barang = listBarang.FirstOrDefault(item => item.kodeBarang == kodeBarang);

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

            JsonHandler<List<Barang>>.writeJsonToFile(filePath, listBarang);
        }

        // DELETE api/<BarangController>/5
        [HttpDelete("{kodeBarang}")]
        public void Delete(String kodeBarang)
        {
            listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath);

            listBarang.RemoveAll(item => item.kodeBarang == kodeBarang);
            JsonHandler<List<Barang>>.writeJsonToFile(filePath, listBarang);
        }
    }
}
