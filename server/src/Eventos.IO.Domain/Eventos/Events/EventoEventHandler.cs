using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoEventHandler :
        INotificationHandler<EventoRegistradoEvent>,
        INotificationHandler<EventoAtualizadoEvent>,
        INotificationHandler<EventoExcluidoEvent>,
        INotificationHandler<EnderecoEventoAdicionadoEvent>,
        INotificationHandler<EnderecoEventoAtualizadoEvent>
    {
        public Task Handle(EventoRegistradoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }

        public Task Handle(EventoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }

        public Task Handle(EventoExcluidoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }

        public Task Handle(EnderecoEventoAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }

        public Task Handle(EnderecoEventoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
