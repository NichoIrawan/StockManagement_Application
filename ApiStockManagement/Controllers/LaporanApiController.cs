using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using StockManagementLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaporanApiController : ControllerBase
    {
        // Placeholder for database context -> Will be changed
        private static String filePath = "Data/ListLaporan.json";
        private static List<Laporan> listLaporan;

        // GET: api/<LaporanApiController>
        [HttpGet]
        public ActionResult Get()
        {
            listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(filePath);
            return listLaporan is null ? NotFound() : Ok(listLaporan);
        }

        // GET api/<LaporanApiController>/5
        [HttpGet("{tanggalPembuatan}")]
        public Laporan Get(DateTime tanggalPembuatan)
        {
            listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(filePath);

            if (listLaporan is null)
            {
                return null;

            }
            var laporan = listLaporan.FirstOrDefault(item => item.tanggalPembuatan == tanggalPembuatan);
            return laporan is null ? null : laporan;
        }


        // POST api/<LaporanApiController>
        [HttpPost]
        public ActionResult Post([FromBody] Laporan newLaporan)
        {
            listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(filePath);

            if (newLaporan == null)
            {
                return NotFound("Laporan cannot be null");
            }

            foreach (Laporan laporan in listLaporan)
            {
                if (laporan.tanggalPembuatan == newLaporan.tanggalPembuatan)
                {
                    return NotFound("Laporan ");
                }
            }

            listLaporan.Add(newLaporan);
            JsonHandler<List<Laporan>>.writeJsonToFile(filePath, listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.tanggalPembuatan }, newLaporan);
        }

        // PUT api/<LaporanApiController>/5
        [HttpPut("{tanggalPembuatan}")]
        public ActionResult Put(DateTime tanggalPembuatan, [FromBody] Laporan newLaporan)
        {
            listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(filePath);
            var laporan = listLaporan.FirstOrDefault(item => item.tanggalPembuatan == tanggalPembuatan);

            if (newLaporan == null)
            {
                return BadRequest("Laporan cannot be null");
            }

            laporan.tanggalPembuatan = newLaporan.tanggalPembuatan;
            laporan.tempatPenyimpanan = newLaporan.tempatPenyimpanan;
            laporan.daftarBarang = newLaporan.daftarBarang;

            JsonHandler<List<Laporan>>.writeJsonToFile(filePath, listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.tanggalPembuatan }, newLaporan);
        }

        // DELETE api/<LaporanApiController>/5
        [HttpDelete("{tanggalPembuatan}")]
        public void Delete(DateTime tanggalPembuatan)
        {

            listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(filePath);
            listLaporan.RemoveAll(item => item.tanggalPembuatan == tanggalPembuatan);
            JsonHandler<List<Laporan>>.writeJsonToFile(filePath, listLaporan);

        }
    }
}
