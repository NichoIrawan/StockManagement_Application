using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiwayatApiController : ControllerBase
    {

        //Placeholder for database context -> Will be changed
        private static String filePath = "Data/ListRiwayat.json";
        private static List<Riwayat> listRiwayat;

        // GET: api/<RiwayatApiController>
        [HttpGet]
        public ActionResult<Riwayat> Get()
        {
            listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(filePath);
            return listRiwayat is null ? NotFound() : Ok(listRiwayat);
        }

        // GET api/<RiwayatApiController>/5
        [HttpGet("{tanggal}")]
        public Riwayat Get(DateTime tanggal)
        {
            listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(filePath);
            if (listRiwayat is null)
            {
                return null;
            }
            var gudang = listRiwayat.FirstOrDefault(item => item.tanggal == tanggal);
            return gudang is null ? null : gudang;
        }

        // POST api/<RiwayatApiController>
        [HttpPost]
        public ActionResult Post([FromBody] Riwayat newRiwayat)
        {
            listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(filePath);

            if (newRiwayat == null)
            {
                return NotFound("Gudang cannot be null");
            }

            foreach (Riwayat riwayat in listRiwayat)
            {
                if (riwayat.tanggal == newRiwayat.tanggal)
                    return NotFound("Gudang with the same code already exists");
            }

            JsonHandler<List<Riwayat>>.writeJsonToFile(filePath, listRiwayat);

            return CreatedAtAction(nameof(Get), new { kodeGudang = newRiwayat.tanggal }, newRiwayat);
        }

        // PUT api/<RiwayatApiController>/5
        [HttpPut("{tanggal}")]
        public ActionResult Put(DateTime tanggal, [FromBody] Riwayat newRiwayat)
        {
            listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(filePath);
            var riwayat = listRiwayat.FirstOrDefault(item => item.tanggal == tanggal);

            if (newRiwayat == null)
            {
                return BadRequest("Laporan cannot be null");
            }

            riwayat.tanggal = newRiwayat.tanggal;
            riwayat.jenis_transaksi = newRiwayat.jenis_transaksi;
            riwayat.barang = newRiwayat.barang;
            riwayat.jumlah_barang = newRiwayat.jumlah_barang;
            riwayat.lokasi_penyimpanan = newRiwayat.lokasi_penyimpanan;
            riwayat.pic = newRiwayat.pic;

            JsonHandler<List<Riwayat>>.writeJsonToFile(filePath, listRiwayat);

            return CreatedAtAction(nameof(Get), new { id = newRiwayat.tanggal }, newRiwayat);
        }

        // DELETE api/<RiwayatApiController>/5
        [HttpDelete("{tanggal}")]
        public void Delete(DateTime tanggal)
        {
            listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(filePath);
            listRiwayat.RemoveAll(item => item.tanggal == tanggal);
            JsonHandler<List<Riwayat>>.writeJsonToFile(filePath, listRiwayat);
        }
    }
}
