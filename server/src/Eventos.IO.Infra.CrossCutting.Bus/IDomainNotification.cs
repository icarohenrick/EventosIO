using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Infra.CrossCutting.Bus
{
    internal interface IDomainNotification<T> where T : Message
    {

    }
}