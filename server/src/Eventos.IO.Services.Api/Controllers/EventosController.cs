﻿using System;
using System.Collections.Generic;
using AutoMapper;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.Services.Api.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.IO.Services.Api.Controllers
{
    public class EventosController : BaseController
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
         
        public EventosController(INotificationHandler<DomainNotification> notifications,
                                 IUser user,
                                 IEventoRepository eventoRepository,
                                 IMapper mapper,
                                 IMediatorHandler mediator) : base(notifications, user, mediator)
        {
            _eventoRepository = eventoRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("eventos")]
        [AllowAnonymous]
        public IEnumerable<EventoViewModel> Get()
        {
            return _mapper.Map<IEnumerable<EventoViewModel>>(_eventoRepository.ObterTodos());
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("eventos/{id:guid}")]
        public EventoViewModel Get(Guid id, int version)
        {
            return _mapper.Map<EventoViewModel>(_eventoRepository.ObterPorId(id));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("eventos/categorias")]
        public IEnumerable<CategoriaViewModel> ObterCategorias()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(_eventoRepository.ObterCategorias());
        }

        [HttpGet]
        [Route("eventos/meus-eventos")]
        [Authorize(Policy = "PodeLerEventos")]
        public IEnumerable<EventoViewModel> ObterMeusEventos()
        {
            return _mapper.Map<IEnumerable<EventoViewModel>>(_eventoRepository.ObterEventoPorOrganizador(OrganizadorId));
        }

        [HttpGet]
        [Route("eventos/meus-eventos/{id:guid}")]
        [Authorize(Policy = "PodeLerEventos")]
        public IActionResult ObterMeuEventoPorId(Guid id)
        {
            var evento = _mapper.Map<EventoViewModel>(_eventoRepository.ObterMeuEventoPorId(id, OrganizadorId));
            return evento == null ? StatusCode(404) : Response(evento);
        }

        [HttpPost]
        [Authorize(Policy ="PodeGravar")]
        [Route("eventos")]
        public IActionResult Post([FromBody]EventoViewModel eventoViewModel)
        {
            if(!ModelStateValida())
            {
                return Response();
            }

            var eventoCommand = _mapper.Map<RegistrarEventoCommand>(eventoViewModel);

            _mediator.EnviarComando(eventoCommand);
            return Response(eventoCommand);
        }

        [HttpPut]
        [Authorize(Policy = "PodeGravar")]
        [Route("eventos")]
        public IActionResult Put([FromBody]EventoViewModel eventoViewModel)
        {
            if (!ModelStateValida())
            {
                return Response();
            }

            var eventoCommand = _mapper.Map<AtualizarEventoCommand>(eventoViewModel);

            _mediator.EnviarComando(eventoCommand);
            return Response(eventoCommand);
        }

        [HttpDelete]
        [Authorize(Policy = "PodeGravar")]
        [Route("eventos/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var eventoViewModel = new EventoViewModel { Id = id };
            var eventoCommand = _mapper.Map<ExcluirEventoCommand>(eventoViewModel);

            _mediator.EnviarComando(eventoCommand);
            return Response(eventoCommand);
        }

        [HttpPost]
        [Authorize(Policy = "PodeGravar")]
        [Route("endereco")]
        public IActionResult Post([FromBody]EnderecoViewModel enderecoViewModel)
        {
            if (!ModelStateValida())
            {
                return Response();
            }

            var eventoCommand = _mapper.Map<IncluirEnderecoEventoCommand>(enderecoViewModel);

            _mediator.EnviarComando(eventoCommand);
            return Response(eventoCommand);
        }

        [HttpPut]
        [Authorize(Policy = "PodeGravar")]
        [Route("endereco")]
        public IActionResult Put([FromBody]EnderecoViewModel enderecoViewModel)
        {
            if (!ModelStateValida())
            {
                return Response();
            }

            var eventoCommand = _mapper.Map<AtualizarEnderecoEventoCommand>(enderecoViewModel);

            _mediator.EnviarComando(eventoCommand);
            return Response(eventoCommand);
        }

        private bool ModelStateValida()
        {
            if (ModelState.IsValid) return true;

            NotificarErroModelInvalida();
            return false;
        }
    }
}
