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

        private readonly JsonHandler<List<Laporan>> _jsonHandlerList = JsonHandler<List<Laporan>>.GetInstance();

        // API to get "Laporan" as List.
        [HttpGet]
        public ActionResult Get()
        {
            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);
            return _listLaporan is null ? NotFound() : Ok(_listLaporan);
        }

        // API to get "Laporan" by tanggalPembuatan.
        [HttpGet("tanggal/{tanggalPembuatan}")]
        public Laporan Get(DateOnly tanggalPembuatan)
        {
            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (_listLaporan is null)
            {
                return null;

            }
            var laporan = _listLaporan.FirstOrDefault(item => item.TanggalPembuatan == tanggalPembuatan);
            return laporan is null ? null : laporan;
        }

        // API to get "Laporan" by tanggalPembuatan.
        [HttpGet("gudang/{kodeGudang}")]
        public List<Laporan> GetByGudang(string kodeGudang)
        {
            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (_listLaporan is null)
            {
                return null;

            }
            var listLaporan = _listLaporan.Where(item => item.TempatPenyimpanan == kodeGudang).ToList();
            return listLaporan is null ? null : listLaporan;
        }

        // API to add a new "Laporan".
        [HttpPost]
        public ActionResult Post([FromBody] Laporan newLaporan)
        {
            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);

            if (newLaporan == null)
            {
                return NotFound("Laporan cannot be null");
            }

            foreach (Laporan laporan in _listLaporan)
            {
                if (laporan.TanggalPembuatan == newLaporan.TanggalPembuatan)
                {
                    return NotFound("Laporan ");
                }
            }

            _listLaporan.Add(newLaporan);
            _jsonHandlerList.WriteJsonToFile(_filePath, _listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.TanggalPembuatan }, newLaporan);
        }

        // API to update an existing "Laporan".
        [HttpPut("{tanggalPembuatan}")]
        public ActionResult Put(DateOnly tanggalPembuatan, [FromBody] Laporan newLaporan)
        {
            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);
            var laporan = _listLaporan.FirstOrDefault(item => item.TanggalPembuatan == tanggalPembuatan);

            if (newLaporan == null)
            {
                return BadRequest("Laporan cannot be null");
            }

            laporan.TanggalPembuatan = newLaporan.TanggalPembuatan;
            laporan.TempatPenyimpanan = newLaporan.TempatPenyimpanan;
            laporan.DaftarBarang = newLaporan.DaftarBarang;

            _jsonHandlerList.WriteJsonToFile(_filePath, _listLaporan);

            return CreatedAtAction(nameof(Get), new { id = newLaporan.TanggalPembuatan }, newLaporan);
        }

        // API to delete an existing "Laporan" by tanggalPembuatan.
        [HttpDelete("{tanggalPembuatan}")]
        public void Delete(DateOnly tanggalPembuatan)
        {

            _listLaporan = _jsonHandlerList.ReadJsonFromFile(_filePath);
            _listLaporan.RemoveAll(item => item.TanggalPembuatan == tanggalPembuatan);
            _jsonHandlerList.WriteJsonToFile(_filePath, _listLaporan);
        }
    }
}

﻿

