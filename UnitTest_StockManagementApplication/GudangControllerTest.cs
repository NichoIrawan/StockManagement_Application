using Xunit;
using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using StockManagement.Models;
using StockManagement.Controller;
using System.Collections.Generic;
using System.Text.Json;
using System;

namespace UnitTest_StockManagementApplication
{
    public class GudangControllerTest : IDisposable
    {
        private GudangController controller;
        private Mock<HttpMessageHandler> handlerMock;

        public GudangControllerTest()
        {
            handlerMock = new Mock<HttpMessageHandler>();
            var client = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://localhost/")
            };
            controller = new GudangControllerWrapper(client);
        }

        [Fact]
        public async Task GetListGudangAsync_ReturnsList()
        {
            var expected = new List<Gudang> { new Gudang { kodeGudang = "G1", namaGudang = "Gudang A", lokasi = "Jakarta" } };
            var json = JsonSerializer.Serialize(expected);

            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Get), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") });

            var result = await controller.GetListGudangAsync();

            Assert.NotNull(result);
            Assert.Equal(expected.Count, result.Count);
        }

        [Fact]
        public async Task GetGudangByIdAsync_ReturnsGudang()
        {
            var gudang = new Gudang { kodeGudang = "", namaGudang = "", lokasi = "" };
            var json = JsonSerializer.Serialize(gudang);

            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Get), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") });

            var result = await controller.GetGudangByIdAsync("");

            /*Assert.NotNull(result);*/
            Assert.Equal(gudang.namaGudang, result.namaGudang);
        }

        [Fact]
        public async Task GetListBarangByIdAsync_ReturnsBarangList()
        {
            var expected = new List<Gudang> { new Gudang { kodeGudang = "G1", namaGudang = "Gudang A", lokasi = "Jakarta" } };
            var json = JsonSerializer.Serialize(expected);

            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.RequestUri.AbsolutePath.Contains("barang")), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") });

            var result = await controller.GetListBarangByIdAsync("G1");

            Assert.NotNull(result);
            Assert.Equal("G1", result[0].kodeGudang);
        }

        [Fact]
        public async Task InputGudangAsync_Success()
        {
            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Post), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.Created });

            var exception = await Record.ExceptionAsync(() =>
                controller.InputGudangAsync(new Gudang { kodeGudang = "G2", namaGudang = "Gudang B", lokasi = "Bandung" }));

            Assert.Null(exception);
        }

        [Fact]
        public async Task UpdateGudangAsync_Success()
        {
            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Put), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.NoContent });

            var exception = await Record.ExceptionAsync(() =>
                controller.UpdateGudangAsync("G1", new Gudang { kodeGudang = "G1", namaGudang = "Gudang C", lokasi = "Surabaya" }));

            Assert.Null(exception);
        }

        [Fact]
        public async Task DeleteGudangAsync_Success()
        {
            handlerMock.Protected()
              .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.Is<HttpRequestMessage>(m => m.Method == HttpMethod.Delete), ItExpr.IsAny<CancellationToken>())
              .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.NoContent });

            var exception = await Record.ExceptionAsync(() => controller.DeleteGudangAsync("G1"));

            Assert.Null(exception);
        }

        public void Dispose()
        {
            controller = null;
            handlerMock = null;
        }

        // Wrapper to inject HttpClient into the GudangController
        private class GudangControllerWrapper : GudangController
        {
            public GudangControllerWrapper(HttpClient client)
            {
                var field = typeof(GudangController).GetField("_client", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                field.SetValue(this, client);
            }
        }
    }
}
