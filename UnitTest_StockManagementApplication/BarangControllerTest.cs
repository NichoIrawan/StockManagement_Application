using Moq;
using Moq.Protected;
using StockManagement.Controllers;
using StockManagement.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;

namespace UnitTest_StockManagementApplication
{
    public class BarangControllerTests
    {
        [Fact]
        public async Task GetListBarangAsync_ReturnsBarangList()
        {
            // Arrange
            var dummyData = new List<Barang>
            {
                new Barang { kodeBarang = "B001", namaBarang = "Pensil", harga = 1000 },
                new Barang { kodeBarang = "B002", namaBarang = "Buku", harga = 5000 }
            };

            var json = JsonSerializer.Serialize(dummyData);
            var mockHandler = new Mock<HttpMessageHandler>();

            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(json)
                });

            var client = new HttpClient(mockHandler.Object)
            {
                BaseAddress = new Uri("https://dummyapi.local/")
            };

            var controller = new BarangControllerForTest(client);

            // Act
            var result = await controller.tampilkanBarang();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("B001", result[0].kodeBarang);
        }
    }

    public class BarangControllerForTest : BarangController
    {
        public BarangControllerForTest(HttpClient client)
        {
            this.GetType().BaseType
                .GetField("_client", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(this, client);
        }
    }
}