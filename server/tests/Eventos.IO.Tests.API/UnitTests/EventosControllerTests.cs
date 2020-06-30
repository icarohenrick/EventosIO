using AutoMapper;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Services.Api.Controllers;
using Eventos.IO.Services.Api.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Eventos.IO.Tests.API.UnitTests
{
    public class EventosControllerTests
    {
        //Modelo AAA = Arrange, Act, Assert

        public EventosController eventosController;
        public Mock<DomainNotificationHandler> mockNotification;
        public Mock<IMapper> mockMapper;
        public Mock<IMediatorHandler> mockMediator;

        public EventosControllerTests()
        {
            mockNotification = new Mock<DomainNotificationHandler>();
            mockMapper = new Mock<IMapper>();
            mockMediator = new Mock<IMediatorHandler>();

            var mockUser = new Mock<IUser>();
            var mockRepository = new Mock<IEventoRepository>();

            eventosController = new EventosController(
                mockNotification.Object,
                mockUser.Object, 
                mockRepository.Object, 
                mockMapper.Object, 
                mockMediator.Object);
        }

        [Fact]
        public void EventosController_RegistrarEvento_RetornarComSucesso()
        {
            //Arrange
            var eventoViewModel = new EventoViewModel();
            var eventoCommand = new RegistrarEventoCommand
            (
                Guid.NewGuid(),
                "Teste", "", "", DateTime.Now, DateTime.Now.AddDays(1), true,
                0, true, "", Guid.NewGuid(), Guid.NewGuid(),

                new IncluirEnderecoEventoCommand
                (
                    Guid.NewGuid(), "", null, "", "", "", "", "", null
                )
            );

            mockMapper.Setup(m => m.Map<RegistrarEventoCommand>(eventoViewModel)).Returns(eventoCommand);

            //Act
            var result = eventosController.Post(eventoViewModel);

            //Assert
            mockMediator.Verify(m => m.EnviarComando(eventoCommand), Times.Once);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void EventosController_RegistrarEvento_RetornarComErrosDeModelState()
        {
            //Arrage
            mockNotification.Setup(m => m.HasNotifications()).Returns(true);

            eventosController.ModelState.AddModelError("Error", "ModelError");
             
            //Act
            var result = eventosController.Post(new EventoViewModel());

            //Assert
            mockMediator.Verify(m => m.EnviarComando(It.IsAny<RegistrarEventoCommand>()), Times.Never);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void EventosController_RegistrarEvento_RetornarComErrosDeDominio()
        {
            //Arrage
            var eventoViewModel = new EventoViewModel();
            var eventoCommand = new RegistrarEventoCommand
            (
                Guid.NewGuid(),
                "Teste", "", "", DateTime.Now, DateTime.Now.AddDays(1), true,
                0, true, "", Guid.NewGuid(), Guid.NewGuid(),

                new IncluirEnderecoEventoCommand
                (
                    Guid.NewGuid(), "", null, "", "", "", "", "", null
                )
            );

            mockMapper.Setup(m => m.Map<RegistrarEventoCommand>(eventoViewModel)).Returns(eventoCommand);

            mockNotification.Setup(m => m.HasNotifications()).Returns(true);

            var notificationList = new List<DomainNotification> { new DomainNotification("Erro", "Erro ao adicionar o evento") };

            mockNotification.Setup(n => n.HasNotifications()).Returns(true);

            //Act
            var result = eventosController.Post(eventoViewModel);

            //Assert
            mockMediator.Verify(m => m.EnviarComando(eventoCommand), Times.Once);
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
