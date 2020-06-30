﻿using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Core.Notifications.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eventos.IO.Site.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificationHandler<DomainNotification> _notifications;

        public SummaryViewComponent(INotificationHandler<DomainNotification> notifications)
        {
            _notifications = notifications;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notifications.GetNotifications());

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Value));

            return View();
        }
    }
}
