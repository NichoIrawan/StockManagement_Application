using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GudangApiController : ControllerBase
    {
        private static readonly string _filePath = "Data/ListGudang.json";
        private static List<Gudang> _listGudang;
        
        private readonly JsonHandler<List<Gudang>> _jsonHandlerList = JsonHandler<List<Gudang>>.GetInstance();
        private readonly JsonHandler<List<Barang>> _jsonHandlerListBarang = JsonHandler<List<Barang>>.GetInstance();

        // API to get "Gudang" as List.
        [HttpGet]
        public ActionResult Get()
        {
            _listGudang = _jsonHandlerList.ReadJsonFromFile(_filePath);
            return _listGudang is null? NotFound() : Ok(_listGudang);
        }

        // API to get "Gudang" by kodeGudang.
        [HttpGet("{kodeGudang}")]
        public Gudang Get(String kodeGudang)
        {
            _listGudang = _jsonHandlerList.ReadJsonFromFile(_filePath);
            if (_listGudang is null)
            {
                return null;
            }
            var gudang = _listGudang.FirstOrDefault(item => item.kodeGudang.Equals(kodeGudang));
            return gudang is null ? null : gudang;
        }

        // API to get "Barang" in a specific "Gudang" by kodeGudang.
        [HttpGet("barang")]
        public ActionResult GetBarangInGudang(String kodeGudang)
        {
            var listBarang = _jsonHandlerListBarang.ReadJsonFromFile(_filePath).Where(item =>
            {
                return item.kodeGudang == kodeGudang;
            }).ToList();

            return Ok(listBarang);
        }

        // API to add a new "Gudang".
        [HttpPost]
        public ActionResult Post([FromBody] Gudang newGudang)
        {
            _listGudang = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (newGudang == null) return NotFound("Gudang cannot be null");

            foreach (Gudang gudang in _listGudang)
            {
                if (gudang.kodeGudang == newGudang.kodeGudang) return BadRequest("Gudang with the same code already exists");
            }

            _listGudang.Add(newGudang);

            _jsonHandlerList.WriteJsonToFile(_filePath, _listGudang);

            return CreatedAtAction(nameof(Get), new { kodeGudang = newGudang.kodeGudang }, newGudang);
        }

        // API to update an existing "Gudang" by kodeGudang.
        [HttpPut("{kodeGudang}")]
        public void Put(string kodeGudang, [FromBody] Gudang gudangBaru)
        {
            _listGudang = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (gudangBaru == null) return;

            var gudang = _listGudang.FirstOrDefault(item => item.kodeGudang == gudangBaru.kodeGudang);

            if (gudang == null) return;

            gudang.namaGudang = gudangBaru.namaGudang;
            gudang.lokasi = gudangBaru.lokasi;

            _jsonHandlerList.WriteJsonToFile(_filePath, _listGudang);
        }

        // API to delete an existing "Gudang" by kodeGudang.
        [HttpDelete("{kodeGudang}")]
        public void Delete(String kodeGudang)
        {
            _listGudang = _jsonHandlerList.ReadJsonFromFile(_filePath);
            _listGudang.RemoveAll(item => item.kodeGudang == kodeGudang);
            _jsonHandlerList.WriteJsonToFile(_filePath, _listGudang);
        }
    }
}
