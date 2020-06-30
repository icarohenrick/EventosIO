using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications.Interfaces;
using System;

namespace Eventos.IO.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IBus
    {
        public static Func<IServiceProvider> ContainerAccessor { get; set; }

        private static IServiceProvider Container => ContainerAccessor();

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            Publish(theEvent);
        }

        public void SendCommand<T>(T theCommand) where T : Command
        {
            Publish(theCommand);
        }

        private static void Publish<T>(T message) where T : Message
        {
            if (Container == null) return;

            var obj = Container.GetService(
                message.MessageType.Equals("DomainNotification") ?
                typeof(Domain.Core.Notifications.Interfaces.INotificationHandler<T>) :
                typeof(Domain.Core.Events.INotificationHandler<T>));

            ((Domain.Core.Events.INotificationHandler<T>)obj).Handle(message);
        }
    }
}
