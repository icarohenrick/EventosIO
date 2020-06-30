namespace Eventos.IO.Domain.Core.Events
{
    public interface INotificationHandler<in T> where T : Message
    {
        void Handle(T Message);
    }
}
