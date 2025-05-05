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
        private static String filePath = "Data/ListGudang.json";
        private static List<Gudang> listGudang;

        // GET: api/<GudangApiController>
        [HttpGet]
        public ActionResult Get()
        {
            listGudang = JsonHandler<List<Gudang>>.readJsonFromFile(filePath);
            return listGudang is null? NotFound() : Ok(listGudang);
        }

        // GET api/<GudangApiController>/5
        [HttpGet("{kodeGudang}")]
        public Gudang Get(String kodeGudang)
        {
            listGudang = JsonHandler<List<Gudang>>.readJsonFromFile(filePath);
            if (listGudang is null)
            {
                return null;
            }
            var gudang = listGudang.FirstOrDefault(item => item.kodeGudang == kodeGudang);
            return gudang is null ? null : gudang;
        }

        // GET api/<GudangApiController>/5
        [HttpGet("barang")]
        public ActionResult GetBarangInGudang(String kodeGudang)
        {
            var listBarang = JsonHandler<List<Barang>>.readJsonFromFile(filePath).Where(item =>
            {
                return item.kodeGudang == kodeGudang;
            }).ToList();

            return Ok(listBarang);
        }

        // POST api/<GudangApiController>
        [HttpPost]
        public ActionResult Post([FromBody] Gudang newGudang)
        {
            listGudang = JsonHandler<List<Gudang>>.readJsonFromFile(filePath);

            if (newGudang == null) return NotFound("Gudang cannot be null");

            foreach (Gudang gudang in listGudang)
            {
                if (gudang.kodeGudang == newGudang.kodeGudang) return BadRequest("Gudang with the same code already exists");
            }

            JsonHandler<List<Gudang>>.writeJsonToFile(filePath, listGudang);

            return CreatedAtAction(nameof(Get), new { kodeGudang = newGudang.kodeGudang }, newGudang);
        }

        // PUT api/<GudangApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gudang gudangBaru)
        {
            listGudang = JsonHandler<List<Gudang>>.readJsonFromFile(filePath);

            if (gudangBaru == null) return;

            var gudang = listGudang.FirstOrDefault(item => item.kodeGudang == gudangBaru.kodeGudang);

            if (gudang == null) return;

            gudang.namaGudang = gudangBaru.namaGudang;
            gudang.lokasi = gudangBaru.lokasi;

            JsonHandler<List<Gudang>>.writeJsonToFile(filePath, listGudang);
        }

        // DELETE api/<GudangApiController>/5
        [HttpDelete("{kodeGudang}")]
        public void Delete(String kodeGudang)
        {
            listGudang = JsonHandler<List<Gudang>>.readJsonFromFile(filePath);
            listGudang.RemoveAll(item => item.kodeGudang == kodeGudang);
            JsonHandler<List<Gudang>>.writeJsonToFile(filePath, listGudang);
        }
    }
}
