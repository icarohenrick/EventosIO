using Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Notifications.Interfaces
{
    public interface INotificationHandler<T> : Events.INotificationHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications();
    }
}
