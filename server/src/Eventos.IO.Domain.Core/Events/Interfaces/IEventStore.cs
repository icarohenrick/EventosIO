using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Events.Interfaces
{
    public interface IEventStore
    {
        void SalvarEvento<T>(T evento) where T : Event;
    }
}
