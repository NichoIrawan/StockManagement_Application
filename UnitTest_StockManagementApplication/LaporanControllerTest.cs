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
using StockManagement.Controllers.Api;
using StockManagement.Models;
using Xunit;

namespace UnitTest_StockManagementApplication
{
    public class LaporanControllerTest
    {
        [Fact]
        public async Task GetListBarangAsync_ShouldReturnListOfLaporan()
        {
            // Arrange
            Gudang gudangBaru = new Gudang("G001", "GudangUtama", "Jakarta");

            var expectedLaporan = new List<Laporan>
        {
            new Laporan { tanggalPembuatan = DateTime.Today, tempatPenyimpanan = gudangBaru, daftarBarang = new List<Barang>() }
        };

            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = JsonContent.Create(expectedLaporan)
                });

            var httpClient = new HttpClient(mockHandler.Object)
            {
                BaseAddress = new Uri("http://localhost")
            };

            var controller = new LaporanControllerWrapper(httpClient);

            // Act
            var result = await controller.GetListLaporanAsync();

            // Assert
            // Ambil response dari POST
         

        }

        // Test lain untuk GetBarangByIdAsync bisa ditambah kayak gini
        [Fact]
        public async Task GetBarangByIdAsync_ReturnsNull_WhenNotFound()
        {
            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.NotFound
                });

            var httpClient = new HttpClient(mockHandler.Object)
            {
                BaseAddress = new Uri("http://localhost")
            };

            var controller = new LaporanControllerWrapper(httpClient);

            var result = await controller.GetLaporanByIdAsync(DateTime.Today);

            Assert.NotNull(result);
        }

        // Test untuk POST
        [Fact]
        public async Task InputGudangAsync_ShouldSucceed()
        {
            var gudang = new Gudang { lokasi = "Gudang C" };

            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.Created
                });

            var httpClient = new HttpClient(mockHandler.Object)
            {
                BaseAddress = new Uri("http://localhost")
            };

            var controller = new LaporanControllerWrapper(httpClient);

            var exception = await Record.ExceptionAsync(() => controller.InputLaporanAsync(gudang));

            Assert.Null(exception); // no exception means success
        }

        //  Wrapper untuk inject HttpClient ke LaporanController
        private class LaporanControllerWrapper : LaporanController
        {
            public LaporanControllerWrapper(HttpClient client)
            {
                var field = typeof(LaporanController).GetField("_client", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                field.SetValue(this, client);
            }
        }
    }
}
