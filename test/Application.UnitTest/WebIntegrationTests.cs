using Xunit;
using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using WebApp253E08; // ✅ Corregido: este es el namespace correcto

namespace Application.UnitTest
{
    public class WebIntegrationTests : IClassFixture<WebApplicationFactory<Program>>

    {
        private readonly WebApplicationFactory<Program> _factory;

        public WebIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("4")]
        [InlineData("5")]
       
        public async Task Get_NonExistingPage_Returns404(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
