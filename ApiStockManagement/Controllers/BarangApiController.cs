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
        private static readonly string _filePath = "Data/ListBarang.json";
        private static List<Barang>? _listBarang;

        // API to get "Barang" as List.
        [HttpGet]
        public ActionResult<IEnumerable<Barang>> Get()
        {
            _listBarang = JsonHandler<List<Barang>>.readJsonFromFile(_filePath);
            
            return _listBarang is null? NotFound() : Ok(_listBarang);
        }

        // API to get "Barang" by kodeBarang.
        [HttpGet("{kodeBarang}")]
        public ActionResult<Barang> Get(string kodeBarang)
        {
            _listBarang = JsonHandler<List<Barang>>.readJsonFromFile(_filePath);

            if (_listBarang is null)
            {
                return NotFound("Barang not found");
            }

            var barang = _listBarang.FirstOrDefault(item => item.kodeBarang == kodeBarang);
            
            return barang is null? NotFound() : Ok(barang);
        }

        // API to add a new "Barang".
        [HttpPost]
        public ActionResult Post([FromBody]Barang newBarang)
        {
            _listBarang = JsonHandler<List<Barang>>.readJsonFromFile(_filePath);

            if (newBarang == null)
            {
                return BadRequest("Barang cannot be null");
            }

            foreach (Barang barang in _listBarang)
            {
                if (barang.kodeBarang == newBarang.kodeBarang)
                {
                    return BadRequest("Barang with the same code already exists");
                }
            }

            _listBarang.Add(newBarang);
            JsonHandler<List<Barang>>.writeJsonToFile(_filePath, _listBarang);

            return CreatedAtAction(nameof(Get), new { id = newBarang.kodeBarang }, newBarang);
        }

        // API to update an existing "Barang" by kodeBarang.
        [HttpPut("{kodeBarang}")]
        public void Put(string kodeBarang, [FromBody]Barang newbarang)
        {
            _listBarang = JsonHandler<List<Barang>>.readJsonFromFile(_filePath);
            var barang = _listBarang.FirstOrDefault(item => item.kodeBarang == kodeBarang);

            if (barang == null) return;

            barang.kodeBarang = newbarang.kodeBarang;
            barang.namaBarang = newbarang.namaBarang;
            barang.kategori = newbarang.kategori;
            barang.stok = newbarang.stok;
            barang.harga = newbarang.harga;
            barang.tanggalKadaluarsa = newbarang.tanggalKadaluarsa;
            barang.kodeGudang = newbarang.kodeGudang;

            JsonHandler<List<Barang>>.writeJsonToFile(_filePath, _listBarang);
        }

        // API to delete an existing "Barang" by kodeBarang.
        [HttpDelete("{kodeBarang}")]
        public void Delete(string kodeBarang)
        {
            _listBarang = JsonHandler<List<Barang>>.readJsonFromFile(_filePath);
            
            if (_listBarang != null)
            {
                _listBarang.RemoveAll(item => item.kodeBarang == kodeBarang);
                JsonHandler<List<Barang>>.writeJsonToFile(_filePath, _listBarang);
            }
        }
    }
}
