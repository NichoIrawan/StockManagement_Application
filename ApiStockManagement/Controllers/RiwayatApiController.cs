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
        private static readonly string _filePath = "Data/ListRiwayat.json";
        private static List<Riwayat>? _listRiwayat;

        // API to get "Riwayat" as List.
        [HttpGet]
        public ActionResult<Riwayat> Get()
        {
            _listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(_filePath);
            return _listRiwayat is null ? NotFound() : Ok(_listRiwayat);
        }

        // API to get "Riwayat" by tanggal.
        [HttpGet("{tanggal}")]
        public Riwayat Get(DateTime tanggal)
        {
            _listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(_filePath);
            if (_listRiwayat is null)
            {
                return null;
            }
            var gudang = _listRiwayat.FirstOrDefault(item => item.tanggal == tanggal);
            return gudang is null ? null : gudang;
        }

        // API to add a new "Riwayat".
        [HttpPost]
        public ActionResult Post([FromBody] Riwayat newRiwayat)
        {
            _listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(_filePath);

            if (newRiwayat == null)
            {
                return NotFound("Gudang cannot be null");
            }

            foreach (Riwayat riwayat in _listRiwayat)
            {
                if (riwayat.tanggal == newRiwayat.tanggal)
                    return NotFound("Gudang with the same code already exists");
            }
            _listRiwayat.Add(newRiwayat);

            JsonHandler<List<Riwayat>>.writeJsonToFile(_filePath, _listRiwayat);


            return CreatedAtAction(nameof(Get), new { kodeGudang = newRiwayat.tanggal }, newRiwayat);
        }

        // API to update an existing "Riwayat" by tanggal.
        [HttpPut("{tanggal}")]
        public ActionResult Put(DateTime tanggal, [FromBody] Riwayat newRiwayat)
        {
            _listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(_filePath);
            var riwayat = _listRiwayat.FirstOrDefault(item => item.tanggal == tanggal);

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

            JsonHandler<List<Riwayat>>.writeJsonToFile(_filePath, _listRiwayat);

            return CreatedAtAction(nameof(Get), new { id = newRiwayat.tanggal }, newRiwayat);
        }

        // API to delete an existing "Riwayat" by tanggal.
        [HttpDelete("{tanggal}")]
        public void Delete(DateTime tanggal)
        {
            _listRiwayat = JsonHandler<List<Riwayat>>.readJsonFromFile(_filePath);
            _listRiwayat.RemoveAll(item => item.tanggal == tanggal);
            JsonHandler<List<Riwayat>>.writeJsonToFile(_filePath, _listRiwayat);
        }
    }
}
