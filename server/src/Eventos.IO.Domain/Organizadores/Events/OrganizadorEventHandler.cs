using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Eventos.IO.Domain.Organizadores.Events
{
    public class OrganizadorEventHandler : INotificationHandler<OrganizadorRegistradoEvent>
    {
        public Task Handle(OrganizadorRegistradoEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
