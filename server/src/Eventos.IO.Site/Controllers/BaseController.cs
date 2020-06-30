using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Core.Notifications.Interfaces;
using Eventos.IO.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Eventos.IO.Site.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificationHandler<DomainNotification> _notifications;
        private readonly IUser _user;

        public Guid OrganizadorId { get; set; }

        public BaseController(INotificationHandler<DomainNotification> notifications, IUser user)
        {
            _notifications = notifications;
            _user = user;

            //OrganizadorId = ControllerContext.HttpContext.User.Identity.

            if(_user.IsAuthenticated())
            {
                OrganizadorId = user.GetUserId();
            }
        }

        protected bool OperacaoValida()
        {
            return (!_notifications.HasNotifications());
        }
    }
}
