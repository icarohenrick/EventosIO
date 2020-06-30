using Eventos.IO.Domain.Core.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Events
{
    public class StoredEvent : Event
    {
        public StoredEvent(Event evento, string data, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = evento.AggregateId;
            MessageType = evento.MessageType;
            Data = data;
            User = user;
        }

        protected StoredEvent() { }

        public Guid Id { get; private set; }

        public string Data { get; private set; }

        public string User { get; private set; }
    }
}
