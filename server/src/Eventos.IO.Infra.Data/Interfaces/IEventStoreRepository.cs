using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Infra.Data.Interface
{
    public interface IEventStoreRepository
    {
        void Store(StoredEvent storedEvent);
    }
}