using AutoMapper;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Organizadores.Commands;
using System;

namespace Eventos.IO.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EventoViewModel, RegistrarEventoCommand>()
                .ConvertUsing(c => new RegistrarEventoCommand( c.Id,
                    c.Nome, c.DescricaoCurta, c.DescricaoLonga, c.DataInicio, c.DataFim,
                    c.Gratuito, c.Valor, c.Online,
                    c.NomeEmpresa, c.OrganizadorId, c.CategoriaId,
                    new IncluirEnderecoEventoCommand(
                        c.Endereco.Id, c.Endereco.Logradouro,
                        c.Endereco.Numero, c.Endereco.Bairro,
                        c.Endereco.CEP, c.Endereco.Complemento,
                        c.Endereco.Cidade, c.Endereco.Estado,
                        c.Id)
                    ));

            CreateMap<EnderecoViewModel, IncluirEnderecoEventoCommand>()
                .ConstructUsing(c => new IncluirEnderecoEventoCommand(Guid.NewGuid(),
                        c.Logradouro, c.Numero, c.Bairro, c.CEP, c.Complemento,
                        c.Cidade, c.Estado, c.EventoId));

            CreateMap<EnderecoViewModel, AtualizarEnderecoEventoCommand>()
                .ConstructUsing(c => new AtualizarEnderecoEventoCommand(c.Id,
                        c.Logradouro, c.Numero, c.Bairro, c.CEP, c.Complemento,
                        c.Cidade, c.Estado, c.EventoId));

            CreateMap<EventoViewModel, AtualizarEventoCommand>()
                .ConvertUsing(c => new AtualizarEventoCommand(c.Id,
                    c.Nome, c.DescricaoCurta, c.DescricaoLonga, c.DataInicio, c.DataFim,
                    c.Gratuito, c.Valor, c.Online,
                    c.NomeEmpresa, c.OrganizadorId, c.CategoriaId));

            CreateMap<EventoViewModel, ExcluirEventoCommand>()
                .ConstructUsing(c => new ExcluirEventoCommand(c.Id));

            CreateMap<OrganizadorViewModel, RegistrarOrganizadorCommand>()
                .ConstructUsing(c => new RegistrarOrganizadorCommand(c.Id, c.Nome, c.CPF, c.Email));
        }
    }
}
