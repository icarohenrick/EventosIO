using Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Domain.Eventos.Repository
{
    public interface IEventoRepository : IRepository<Evento>
    {
        Evento ObterMeuEventoPorId(Guid id, Guid organizadorId);
        IEnumerable<Evento> ObterEventoPorOrganizador(Guid organizadorId);
        Endereco ObterEnderecoPorId(Guid Id);
        void AdicionarEndereco(Endereco endereco);
        void AtualizarEndereco(Endereco endereco);
        IEnumerable<Categoria> ObterCategorias();
    }
}
