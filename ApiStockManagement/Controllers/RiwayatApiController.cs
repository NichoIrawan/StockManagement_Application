using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiwayatApiController : ControllerBase
    {

        //Placeholder for database context -> Will be changed
        new List<Riwayat> listRiwayat = new List<Riwayat>()
        {
            new Riwayat(DateTime.Now, "Masuk", new Barang(), 10, new Gudang(), new User()),
            new Riwayat(DateTime.Now, "Keluar", new Barang(), 5, new Gudang(), new User()),
        };

        // GET: api/<RiwayatApiController>
        [HttpGet]
        public IEnumerable<Riwayat> Get()
        {
            return listRiwayat;
        }

        // GET api/<RiwayatApiController>/5
        [HttpGet("{id}")]
        public Riwayat Get(int id)
        {
            return listRiwayat.ElementAt(id);
        }

        // POST api/<RiwayatApiController>
        [HttpPost]
        public void Post([FromBody] Riwayat riwayat)
        {
            listRiwayat.Add(riwayat);
        }

        // PUT api/<RiwayatApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Riwayat newRiwayat)
        {
            Riwayat riwayat = listRiwayat.ElementAt(id);

            if (riwayat == null)
            {
                return;
            }

            riwayat.tanggal = newRiwayat.tanggal;
            riwayat.jenis_transaksi = newRiwayat.jenis_transaksi;
            riwayat.barang = newRiwayat.barang;
            riwayat.jumlah_barang = newRiwayat.jumlah_barang;
            riwayat.lokasi_penyimpanan = newRiwayat.lokasi_penyimpanan;
            riwayat.pic = newRiwayat.pic;
        }

        // DELETE api/<RiwayatApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                listRiwayat.RemoveAt(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Id Riwayat tidak ditemukan");
            }
        }
    }
}
