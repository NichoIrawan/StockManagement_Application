using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using StockManagement.Controllers;
using StockManagement.Models;

namespace StockManagement.Tests
{
    [TestClass]
    public class BarangControllerTests
    {
        private TestHttpMessageHandler _httpMessageHandler;
        private BarangController _barangController;

        [TestInitialize]
        public void Setup()
        {
            // Use a custom HttpMessageHandler
            _httpMessageHandler = new TestHttpMessageHandler();
            var httpClient = new HttpClient(_httpMessageHandler)
            {
                BaseAddress = new Uri("http://localhost:5052/api/")
            };

            // Replace the internal HttpClient of BarangController
            _barangController = new BarangController();
            typeof(BarangController)
                .GetField("_client", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(_barangController, httpClient);
        }

        [TestMethod]
        public async Task TampilkanBarang_ReturnsListOfBarang()
        {
            // Arrange
            var expectedBarangList = new List<Barang>
            {
                new Barang { kodeBarang = "B001", namaBarang = "Barang1", stok = 10, harga = 1000 },
                new Barang { kodeBarang = "B002", namaBarang = "Barang2", stok = 20, harga = 2000 }
            };

            _httpMessageHandler.SetResponse(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(JsonSerializer.Serialize(expectedBarangList), Encoding.UTF8, "application/json")
            });

            // Act
            var result = await _barangController.tampilkanBarang();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBarangList.Count, result.Count);
            Assert.AreEqual(expectedBarangList[0].kodeBarang, result[0].kodeBarang);
        }

        [TestMethod]
        public async Task CariBarangDenganId_ReturnsBarang()
        {
            // Arrange
            var expectedBarang = new Barang { kodeBarang = "B001", namaBarang = "Barang1", stok = 10, harga = 1000 };

            _httpMessageHandler.SetResponse(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(JsonSerializer.Serialize(expectedBarang), Encoding.UTF8, "application/json")
            });

            // Act
            var result = await _barangController.cariBarangDenganId("B001");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBarang.kodeBarang, result.kodeBarang);
        }

        [TestMethod]
        public async Task BeliBarang_SendsPostRequest()
        {
            // Arrange
            var barang = new Barang { kodeBarang = "B001", namaBarang = "Barang1", stok = 10, harga = 1000 };

            _httpMessageHandler.SetResponse(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            });

            // Act
            await _barangController.beliBarang(barang);

            // Assert
            Assert.IsTrue(_httpMessageHandler.LastRequest.Method == HttpMethod.Post);
        }

        [TestMethod]
        public async Task UpdateDataBarang_SendsPutRequest()
        {
            // Arrange
            var barang = new Barang { kodeBarang = "B001", namaBarang = "Barang1", stok = 10, harga = 1000 };

            _httpMessageHandler.SetResponse(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            });

            // Act
            await _barangController.updateDataBarang("B001", barang);

            // Assert
            Assert.IsTrue(_httpMessageHandler.LastRequest.Method == HttpMethod.Put);
        }

        [TestMethod]
        public async Task JualBarang_SendsDeleteRequest()
        {
            // Arrange
            _httpMessageHandler.SetResponse(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            });

            // Act
            await _barangController.jualBarang("B001");

            // Assert
            Assert.IsTrue(_httpMessageHandler.LastRequest.Method == HttpMethod.Delete);
        }
    }

    // Custom HttpMessageHandler for testing
    public class TestHttpMessageHandler : HttpMessageHandler
    {
        private HttpResponseMessage _response;
        public HttpRequestMessage LastRequest { get; private set; }

        public void SetResponse(HttpResponseMessage response)
        {
            _response = response;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            LastRequest = request;
            return Task.FromResult(_response);
        }
    }
}