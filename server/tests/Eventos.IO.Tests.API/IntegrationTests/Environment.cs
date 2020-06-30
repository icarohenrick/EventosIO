using Eventos.IO.Services.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace Eventos.IO.Tests.API.IntegrationTests
{
    public class Environment
    {
        public static TestServer Server;
        public static HttpClient Client;

        public static void CriarServidor()
        {
            Server = new TestServer(
               new WebHostBuilder()
               .UseEnvironment("testing")
               .UseUrls("https://localhost:5001")
               .UseStartup<StartupTests>()
            );

            Client = Server.CreateClient();
        }
    }
}
