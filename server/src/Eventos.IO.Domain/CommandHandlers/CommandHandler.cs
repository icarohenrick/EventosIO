using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using FluentValidation.Results;
using MediatR;

namespace Eventos.IO.Domain.Commands
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IMediatorHandler _mediator;
        private readonly DomainNotificationHandler _notifications;

        public CommandHandler(
            IUnitOfWork uow,
            IMediatorHandler mediator, 
            INotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)notifications;
        }

        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                _mediator.PublicarEvento(new DomainNotification(error.PropertyName, error.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;

            var commandReponse = _uow.Commit();

            if (commandReponse.Sucess)
                return true;

            _mediator.PublicarEvento(new DomainNotification("Commit", "Ocorreu um erro ao salvar os dados no banco"));

            return false;
        }
    }
}
