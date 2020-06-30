using Eventos.IO.Domain.Core.Events;
using System;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EnderecoEventoAdicionadoEvent : Event
    {
        public Guid Id { get; set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public EnderecoEventoAdicionadoEvent(
            Guid enderecoId,
            string logradouro,
            string numero,
            string bairro,
            string cep,
            string complemento,
            string cidade,
            string estado, 
            Guid eventoId)
        {
            Id = enderecoId;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            AggregateId = eventoId;
        }
    }
}
