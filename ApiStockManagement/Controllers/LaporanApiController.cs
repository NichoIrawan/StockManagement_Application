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
        private static readonly string _filePath = "Data/ListLaporan.json";
        private static List<Laporan> _listLaporan;

        // API to get "Laporan" as List.
        [HttpGet]
        public ActionResult Get()
        {
            _listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(_filePath);
            return _listLaporan is null ? NotFound() : Ok(_listLaporan);
        }

        // API to get "Laporan" by tanggalPembuatan.
        [HttpGet("{tanggalPembuatan}")]
        public Laporan Get(DateTime tanggalPembuatan)
        {
            _listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(_filePath);

            if (_listLaporan is null)
            {
                return null;

            }
            var laporan = _listLaporan.FirstOrDefault(item => item.tanggalPembuatan == tanggalPembuatan);
            return laporan is null ? null : laporan;
        }


        // API to add a new "Laporan".
        [HttpPost]
        public ActionResult Post([FromBody] Laporan newLaporan)
        {
            _listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(_filePath);

            if (newLaporan == null)
            {
                return NotFound("Laporan cannot be null");
            }

            foreach (Laporan laporan in _listLaporan)
            {
                if (laporan.tanggalPembuatan == newLaporan.tanggalPembuatan)
                {
                    return NotFound("Laporan ");
                }
            }

            _listLaporan.Add(newLaporan);
            JsonHandler<List<Laporan>>.writeJsonToFile(_filePath, _listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.tanggalPembuatan }, newLaporan);
        }

        // API to update an existing "Laporan".
        [HttpPut("{tanggalPembuatan}")]
        public ActionResult Put(DateTime tanggalPembuatan, [FromBody] Laporan newLaporan)
        {
            _listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(_filePath);
            var laporan = _listLaporan.FirstOrDefault(item => item.tanggalPembuatan == tanggalPembuatan);

            if (newLaporan == null)
            {
                return BadRequest("Laporan cannot be null");
            }

            laporan.tanggalPembuatan = newLaporan.tanggalPembuatan;
            laporan.tempatPenyimpanan = newLaporan.tempatPenyimpanan;
            laporan.daftarBarang = newLaporan.daftarBarang;

            JsonHandler<List<Laporan>>.writeJsonToFile(_filePath, _listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.tanggalPembuatan }, newLaporan);
        }

        // API to delete an existing "Laporan" by tanggalPembuatan.
        [HttpDelete("{tanggalPembuatan}")]
        public void Delete(DateTime tanggalPembuatan)
        {

            _listLaporan = JsonHandler<List<Laporan>>.readJsonFromFile(_filePath);
            _listLaporan.RemoveAll(item => item.tanggalPembuatan == tanggalPembuatan);
            JsonHandler<List<Laporan>>.writeJsonToFile(_filePath, _listLaporan);

        }
    }
}

﻿

