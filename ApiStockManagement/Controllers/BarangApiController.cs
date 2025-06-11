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
        private readonly JsonHandler<List<Barang>> _jsonHandlerList = JsonHandler<List<Barang>>.GetInstance();

        private readonly string _filePath = "Data/ListBarang.json";
        private List<Barang>? _listBarang;

        // API to get "Barang" as List.
        [HttpGet]
        public ActionResult<IEnumerable<Barang>> Get()
        {
            _listBarang = _jsonHandlerList.ReadJsonFromFile(_filePath);
            
            return _listBarang is null? NotFound() : Ok(_listBarang);
        }

        // API to get "Barang" by kodeBarang.
        [HttpGet("{kodeBarang}")]
        public ActionResult<Barang> Get(string kodeBarang)
        {
            _listBarang = _jsonHandlerList.ReadJsonFromFile(_filePath);

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
            _listBarang = _jsonHandlerList.ReadJsonFromFile(_filePath);

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
            _jsonHandlerList.WriteJsonToFile(_filePath, _listBarang);

            return CreatedAtAction(nameof(Get), new { id = newBarang.kodeBarang }, newBarang);
        }

        // API to update an existing "Barang" by kodeBarang.
        [HttpPut("{kodeBarang}")]
        public ActionResult Put(string kodeBarang, [FromBody]Barang newBarang)
        {
            _listBarang = _jsonHandlerList.ReadJsonFromFile(_filePath);
            var barang = _listBarang.FirstOrDefault(item => item.kodeBarang == kodeBarang);

            try
            {
                barang.kodeBarang = newBarang.kodeBarang;
                barang.namaBarang = newBarang.namaBarang;
                barang.kategori = newBarang.kategori;
                barang.stok = newBarang.stok;
                barang.harga = newBarang.harga;
                barang.tanggalKadaluarsa = newBarang.tanggalKadaluarsa;
                barang.kodeGudang = newBarang.kodeGudang;
            }
            catch
            {
                return NotFound("Barang not found or invalid data provided");
            }

            _jsonHandlerList.WriteJsonToFile(_filePath, _listBarang);
            return NoContent();
        }

        // API to delete an existing "Barang" by kodeBarang.
        [HttpDelete("{kodeBarang}")]
        public ActionResult Delete(string kodeBarang)
        {
            _listBarang = _jsonHandlerList.ReadJsonFromFile(_filePath);

            try
            {
                _listBarang.RemoveAll(item => item.kodeBarang == kodeBarang);
                _jsonHandlerList.WriteJsonToFile(_filePath, _listBarang);
                return NoContent();
            }
            catch
            {
                return BadRequest("List Barang cannot be empty");
            }
        }
    }
}
