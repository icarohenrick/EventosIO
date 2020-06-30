using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace Eventos.IO.Infra.CrossCutting.AspNetFilters
{
    public class GlobalActionLogger : IActionFilter
    {
        private readonly ILogger<GlobalActionLogger> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public GlobalActionLogger(
            ILogger<GlobalActionLogger> logger,
            IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_hostingEnvironment.IsDevelopment())
            {
                //var data = new
                //{
                //    Version = "v1.0",
                //    User = context.HttpContext.User.Identity.Name,
                //    IP = context.HttpContext.Connection.RemoteIpAddress.ToString(),
                //    Hostname = context.HttpContext.Request.Host.ToString(),
                //    AreaAccessed = context.HttpContext.Request.GetDisplayUrl(),
                //    Action = context.ActionDescriptor.DisplayName,
                //    TimeStamp = DateTime.Now
                //};

                //_logger.LogInformation(1,data.ToString());
            }

            if(_hostingEnvironment.IsProduction())
            {
                //ElmahIO Implementention
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
