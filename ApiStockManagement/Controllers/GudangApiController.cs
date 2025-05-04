using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;
using static StockManagement.Models.Gudang;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStockManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GudangApiController : ControllerBase
    {
        //Placeholder for database context -> Will be changed
        private List<Gudang> ListGudang = new List<Gudang>()
        {
            new Gudang("Gudang A", "Lokasi A", new List<Barang>()),
            new Gudang("Gudang B", "Lokasi B", new List<Barang>()),
            new Gudang("Gudang C", "Lokasi C", new List<Barang>())
        };

        // GET: api/<GudangApiController>
        [HttpGet]
        public IEnumerable<Gudang> Get()
        {
            return ListGudang;
        }

        // GET api/<GudangApiController>/5
        [HttpGet("{id}")]
        public Gudang Get(int id)
        {
            return ListGudang.ElementAt(id);
        }

        // POST api/<GudangApiController>
        [HttpPost]
        public void Post([FromBody] Gudang gudangBaru)
        {
            ListGudang.Add(gudangBaru);
        }

        // PUT api/<GudangApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gudang gudangBaru)
        {
            Gudang gudang = ListGudang.ElementAt(id);
            if (gudang != null)
            {
                return;
            }
            gudang.NamaGudang = gudangBaru.NamaGudang;
            gudang.Lokasi = gudangBaru.Lokasi;
            gudang.DaftarBarang = gudangBaru.DaftarBarang;
        }

        // DELETE api/<GudangApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                ListGudang.RemoveAt(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Id tidak ditemukan");
            }
        }
    }
}
