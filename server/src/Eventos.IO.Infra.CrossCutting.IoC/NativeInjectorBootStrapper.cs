using AutoMapper;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Application.Services;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Events.Interfaces;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Events;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Handlers;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Domain.Organizadores.Commands;
using Eventos.IO.Domain.Organizadores.Events;
using Eventos.IO.Domain.Organizadores.Repository;
using Eventos.IO.Infra.CrossCutting.AspNetFilters;
using Eventos.IO.Infra.CrossCutting.Bus;
using Eventos.IO.Infra.CrossCutting.Identity.Models;
using Eventos.IO.Infra.CrossCutting.Identity.Services;
using Eventos.IO.Infra.Data.Context;
using Eventos.IO.Infra.Data.EventSourcing;
using Eventos.IO.Infra.Data.Interface;
using Eventos.IO.Infra.Data.Repository;
using Eventos.IO.Infra.Data.UoW;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Eventos.IO.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //ASPNET 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IEventoAppService, EventoAppService>();
            services.AddScoped<IOrganizadorAppService, OrganizadorAppService>();

            //Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Domain - Commands
            services.AddScoped<MediatR.INotificationHandler<RegistrarEventoCommand>, EventoCommandHandler>();
            services.AddScoped<MediatR.INotificationHandler<AtualizarEventoCommand>, EventoCommandHandler>();
            services.AddScoped<MediatR.INotificationHandler<ExcluirEventoCommand>, EventoCommandHandler>();
            services.AddScoped<MediatR.INotificationHandler<IncluirEnderecoEventoCommand>, EventoCommandHandler>();
            services.AddScoped<MediatR.INotificationHandler<AtualizarEnderecoEventoCommand>, EventoCommandHandler>();
            services.AddScoped<MediatR.INotificationHandler<RegistrarOrganizadorCommand>, OrganizadorCommandHandler>();

            // Domain - Eventos
            services.AddScoped<MediatR.INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<MediatR.INotificationHandler<EventoRegistradoEvent>, EventoEventHandler>();
            services.AddScoped<MediatR.INotificationHandler<EventoAtualizadoEvent>, EventoEventHandler>();
            services.AddScoped<MediatR.INotificationHandler<EventoExcluidoEvent>, EventoEventHandler>();
            services.AddScoped<MediatR.INotificationHandler<EnderecoEventoAdicionadoEvent>, EventoEventHandler>();
            services.AddScoped<MediatR.INotificationHandler<EnderecoEventoAtualizadoEvent>, EventoEventHandler>();
            services.AddScoped<MediatR.INotificationHandler<OrganizadorRegistradoEvent>, OrganizadorEventHandler>();

            // Infra - Data
            services.AddScoped<IEventoRepository, EventoRepository>();
            services.AddScoped<IOrganizadorRepository, OrganizadorRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEventStoreRepository, EventStoreRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();

            services.AddScoped<EventosContext>();
            services.AddScoped<EventStoreSQLContext>();

            //Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();

            //Infra - Identity
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddSingleton<IUser, AspNetUser>();

            //Infra - filtros
            services.AddScoped<ILogger<GlobalExceptionHandlingFilter>, Logger<GlobalExceptionHandlingFilter>>();
            services.AddScoped<ILogger<GlobalActionLogger>, Logger<GlobalActionLogger>>();
            services.AddScoped<GlobalExceptionHandlingFilter>();
            services.AddScoped<GlobalActionLogger>();
        }
    }
}
