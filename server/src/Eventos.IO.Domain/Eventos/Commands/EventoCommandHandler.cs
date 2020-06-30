using Eventos.IO.Domain.Commands;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos.Events;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class EventoCommandHandler : CommandHandler,
        INotificationHandler<RegistrarEventoCommand>,
        INotificationHandler<AtualizarEventoCommand>,
        INotificationHandler<ExcluirEventoCommand>,
        INotificationHandler<IncluirEnderecoEventoCommand>,
        INotificationHandler<AtualizarEnderecoEventoCommand>
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IUser _user;
        private readonly IMediatorHandler _mediator;

        public EventoCommandHandler(
            IEventoRepository eventoRepository,
            IUnitOfWork uow,
            INotificationHandler<DomainNotification> notifications,
            IUser user,
            IMediatorHandler mediator) : base(uow, mediator, notifications)
        {
            _eventoRepository = eventoRepository;
            _user = user;
            _mediator = mediator;
        }

        public Task Handle(RegistrarEventoCommand Message, CancellationToken cancellationToken)
        {
            var endereco = new Endereco(Message.Endereco.Id, Message.Endereco.Logradouro,
            Message.Endereco.Numero, Message.Endereco.Bairro, Message.Endereco.CEP,
            Message.Endereco.Complemento, Message.Endereco.Cidade, Message.Endereco.Estado, Message.Id);

            var evento = Evento.EventoFactory.NovoEventoCompleto( Message.Id,
                Message.Nome,
                Message.DescricaoCurta,
                Message.DescricaoLonga,
                Message.DataInicio,
                Message.DataFim,
                Message.Gratuito,
                Message.Valor,
                Message.Online,
                Message.NomeEmpresa,
                Message.OrganizadorId, endereco, Message.CategoriaId);

            if (!EventoValido(evento)) return Task.FromResult(Unit.Value);


             _eventoRepository.Adicionar(evento);

            if(Commit())
            {
                _mediator.PublicarEvento(new EventoRegistradoEvent(
                    evento.Id, 
                    evento.Nome,
                    evento.DataInicio, 
                    evento.DataFim,
                    evento.Gratuito,
                    evento.Valor,
                    evento.Online,
                    evento.NomeEmpresa));
            }

            return Task.FromResult(Unit.Value);
        }

        public Task Handle(AtualizarEventoCommand Message, CancellationToken cancellationToken)
        {
            var eventoAtual = _eventoRepository.ObterPorId(Message.Id);

            if (!EventoExistente(Message.Id, Message.MessageType))
                return Task.FromResult(Unit.Value);

            if(eventoAtual.OrganizadorId != _user.GetUserId())
            {
                _mediator.PublicarEvento(new DomainNotification(Message.MessageType, "Evento não pertence ao Organizador"));
                return Task.FromResult(Unit.Value);
            }

            var evento = Evento.EventoFactory.NovoEventoCompleto(Message.Id,
                Message.Nome,
                Message.DescricaoCurta,
                Message.DescricaoLonga,
                Message.DataInicio,
                Message.DataFim,
                Message.Gratuito,
                Message.Valor,
                Message.Online,
                Message.NomeEmpresa,
                Message.OrganizadorId, eventoAtual.Endereco, Message.CategoriaId);

            if(!evento.Online && evento.Endereco == null)
            {
                _mediator.PublicarEvento(new DomainNotification(Message.MessageType, "Não é possível atualizar um evento sem informar um endereço"));
                return Task.FromResult(Unit.Value);
            }

            if (!EventoValido(evento)) return Task.FromResult(Unit.Value);

            _eventoRepository.Atualizar(evento);

            if(Commit())
            {
                _mediator.PublicarEvento(new EventoAtualizadoEvent(evento.Id,
                    evento.Nome,
                    evento.DescricaoCurta,
                    evento.DescricaoLonga,
                    evento.DataInicio,
                    evento.DataFim,
                    evento.Gratuito,
                    evento.Valor,
                    evento.Online,
                    evento.NomeEmpresa));
            }

            return Task.FromResult(Unit.Value);
        }

        public Task Handle(ExcluirEventoCommand Message, CancellationToken cancellationToken)
        {
            if (!EventoExistente(Message.Id, Message.MessageType))
                return Task.FromResult(Unit.Value);

            var eventoAtual = _eventoRepository.ObterPorId(Message.Id);

            if (eventoAtual.OrganizadorId != _user.GetUserId())
            {
                _mediator.PublicarEvento(new DomainNotification(Message.MessageType, "Evento não pertence ao Organizador"));
                return Task.FromResult(Unit.Value);
            }
            
            eventoAtual.ExcluirEvento();

            _eventoRepository.Atualizar(eventoAtual);

            if(Commit())
            {
                _mediator.PublicarEvento(new EventoExcluidoEvent(Message.Id));
            }

            return Task.FromResult(Unit.Value);
        }

        private bool EventoValido(Evento evento)
        {
            if (evento.EhValido()) return true;

            NotificarValidacoesErro(evento.ValidationResult);
            return false;
        }

        private bool EventoExistente(Guid id, string messageType)
        {
            var evento = _eventoRepository.ObterPorId(id);

            if (evento != null)
                return true;

            _mediator.PublicarEvento(new DomainNotification(messageType, "Evento não encontrado."));

            return false;
        }

        public Task Handle(IncluirEnderecoEventoCommand Message, CancellationToken cancellationToken)
        {
            var endereco = new Endereco(
                Message.Id,
                Message.Logradouro, 
                Message.Numero, 
                Message.Bairro, 
                Message.CEP, 
                Message.Complemento, 
                Message.Cidade, 
                Message.Cidade, 
                Message.EventoId.Value);

            if(!endereco.EhValido())
            {
                NotificarValidacoesErro(endereco.ValidationResult);
                return Task.FromResult(Unit.Value);
            }

            _eventoRepository.AdicionarEndereco(endereco);

            if(Commit())
            {
                _mediator.PublicarEvento(new EnderecoEventoAdicionadoEvent(
                endereco.Id,
                endereco.Logradouro,
                endereco.Numero,
                endereco.Bairro,
                endereco.CEP,
                endereco.Complemento,
                endereco.Cidade,
                endereco.Cidade,
                endereco.EventoId.Value));
            }

            return Task.FromResult(Unit.Value);
        }

        public Task Handle(AtualizarEnderecoEventoCommand Message, CancellationToken cancellationToken)
        {
            var endereco = new Endereco(
                 Message.Id,
                 Message.Logradouro,
                 Message.Numero,
                 Message.Bairro,
                 Message.CEP,
                 Message.Complemento,
                 Message.Cidade,
                 Message.Estado,
                 Message.EventoId.Value);

            if (!endereco.EhValido())
            {
                NotificarValidacoesErro(endereco.ValidationResult);
                return Task.FromResult(Unit.Value);
            }

            _eventoRepository.AtualizarEndereco(endereco);

            if (Commit())
            {
                _mediator.PublicarEvento(new EnderecoEventoAtualizadoEvent(
                endereco.Id,
                endereco.Logradouro,
                endereco.Numero,
                endereco.Bairro,
                endereco.CEP,
                endereco.Complemento,
                endereco.Cidade,
                endereco.Estado,
                endereco.EventoId.Value));
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
