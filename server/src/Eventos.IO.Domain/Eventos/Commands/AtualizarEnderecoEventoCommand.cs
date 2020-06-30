using Eventos.IO.Domain.Core.Commands;
using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEnderecoEventoCommand : Command
    {
        public AtualizarEnderecoEventoCommand(
            Guid id,
            string logradouro,
            string numero,
            string bairro,
            string cep,
            string complemento,
            string cidade,
            string estado,
            Guid? eventoId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            EventoId = eventoId;
        }

        public Guid Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid? EventoId { get; private set; }
    }
}
