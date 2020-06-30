using Eventos.IO.Domain.Commands;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Domain.Organizadores.Events;
using Eventos.IO.Domain.Organizadores.Repository;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Eventos.IO.Domain.Organizadores.Commands
{
    public class OrganizadorCommandHandler : CommandHandler, INotificationHandler<RegistrarOrganizadorCommand>
    {
        private readonly IMediatorHandler _mediator;
        private readonly IOrganizadorRepository _organizadorRepository;

        public OrganizadorCommandHandler(
            IUnitOfWork uow,
            IOrganizadorRepository organizadorRepository,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(uow, mediator, notifications)
        {
            _mediator = mediator;
            _organizadorRepository = organizadorRepository;
        }

        public Task Handle(RegistrarOrganizadorCommand Message, CancellationToken cancellationToken)
        {
            var organizador = new Organizador(Message.Id, Message.Nome, Message.CPF, Message.Email);

            if(!organizador.EhValido())
            {
                NotificarValidacoesErro(organizador.ValidationResult);
                return Task.FromResult(Unit.Value);
            }

            var organizadorExistente = _organizadorRepository.Buscar(o => o.CPF == organizador.CPF || o.Email == organizador.Email);

            if(organizadorExistente.Any())
            {
                _mediator.PublicarEvento(new DomainNotification(Message.MessageType, "CPF ou E-mail já utilizados"));
            }

            _organizadorRepository.Adicionar(organizador);

            if (Commit())
            {
                _mediator.PublicarEvento(new OrganizadorRegistradoEvent(organizador.Id, organizador.Nome, organizador.CPF, organizador.Email));
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
