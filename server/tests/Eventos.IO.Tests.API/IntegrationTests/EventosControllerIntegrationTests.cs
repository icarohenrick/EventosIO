using Eventos.IO.Services.Api.ViewModels;
using Eventos.IO.Tests.API.IntegrationTests.DTO;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Eventos.IO.Tests.API.IntegrationTests
{
    public class EventosControllerIntegrationTests
    {
        public EventosControllerIntegrationTests()
        {
            Environment.CriarServidor();
        }

        [Fact]
        public async Task EventosController_RegistrarNovoEvento_RetornarComSucesso()
        {
            //Arrange
            var login = await UserUtils.RealizarLoginOrganizador(Environment.Client);

            var evento = new EventoViewModel
            {
                Nome = "DevXperience",
                DescricaoCurta = "Um evento de teste",
                DescricaoLonga = "Um evento de Tecnologia para testes",
                CategoriaId = new Guid("42083bb8-d2b4-4677-8127-0afb1925fa37"),
                DataInicio = DateTime.Now.AddDays(10),
                DataFim = DateTime.Now.AddDays(13),
                Gratuito = false,
                Valor = 500,
                NomeEmpresa = "DevX",
                Online = true,
                Endereco = new EnderecoViewModel(),
                OrganizadorId = new Guid(login.user.id)
            };

            //act
            var response = await Environment.Server
                .CreateRequest("api/v1/eventos")
                .AddHeader("Authorization", "Bearer " + login.access_token)
                .And(request => request.Content = new StringContent(JsonConvert.SerializeObject(evento), Encoding.UTF8, "application/json"))
                .PostAsync();

            var eventoResult = JsonConvert.DeserializeObject<EventoJsonDTO>(await response.Content.ReadAsStringAsync());

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.IsType<EventoDTO>(eventoResult.data);
        }
    }
}
