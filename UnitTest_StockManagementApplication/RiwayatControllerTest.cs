using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using ApiStockManagement.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using StockManagement.Controller;
using StockManagement.Models;
using Xunit;

namespace UnitTest_StockManagementApplication
{
    public class RiwayatApiControllerTests
    {
        private readonly string filePath = "Data/ListRiwayat.json";

        [Fact]
        public void Get_ShouldReturnListRiwayat_WhenFileIsValid()
        {
            // Arrange
            var controller = new RiwayatApiController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var data = Assert.IsType<List<Riwayat>>(okResult.Value);

            Assert.NotEmpty(data); // asumsikan JSON ada isinya
        }

        [Fact]
        public void GetByTanggal_ShouldReturnRiwayat_WhenTanggalExists()
        {
            // Arrange
            var controller = new RiwayatApiController();
            var expectedTanggal = new DateTime(2023, 10, 01);

            // Act
            var result = controller.Get(expectedTanggal);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedTanggal, result.tanggal);
        }
    }
}
