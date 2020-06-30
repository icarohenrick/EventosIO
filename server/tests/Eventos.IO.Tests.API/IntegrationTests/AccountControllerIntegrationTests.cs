
using Eventos.IO.Infra.CrossCutting.Identity.Models.AccountViewModels;
using Eventos.IO.Tests.API.IntegrationTests.DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Eventos.IO.Tests.API.IntegrationTests
{
    public class AccountControllerIntegrationTests
    {
        public AccountControllerIntegrationTests()
        {
            Environment.CriarServidor();
        }

        [Fact]
        public async Task AccountController_RegistrarNovoOrganizador_RetornarComSucesso()
        {
            //Arrange
            var user = new RegisterViewModel
            {
                Nome = "Icaro Henrique",
                CPF = "37922797036",
                Email = "contatoPessoal@ihtech.net.br",
                Password = "Teste@123",
                ConfirmPassword = "Teste@123"
            };

            var postContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            //Act
            var response = await Environment.Client.PostAsync("api/v1/nova-conta", postContent);
            var userResult = JsonConvert.DeserializeObject<UsuarioJsonDTO>(await response.Content.ReadAsStringAsync());

            // Assert
            response.EnsureSuccessStatusCode();
            var token = userResult.data.access_token;
            Assert.NotEmpty(token);
        }
    }
}
