using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Events.Interfaces;
using Eventos.IO.Infra.Data.Context;
using Eventos.IO.Infra.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Eventos.IO.Infra.Data.Repository
{
    public class EventStoreRepository : IEventStoreRepository
    {
        protected EventStoreSQLContext Db;
        protected DbSet<StoredEvent> Dbset;

        public EventStoreRepository(EventStoreSQLContext context)
        {
            Db = context;
            this.Dbset = Db.Set<StoredEvent>();
        }

        public void Store(StoredEvent storedEvent)
        {
            if (storedEvent != null)
            {
                Dbset.Add(storedEvent);
                Db.SaveChanges();
            }
        }
    }
}
