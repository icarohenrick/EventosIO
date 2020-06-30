using Eventos.IO.Domain.Core.Models;
using Eventos.IO.Domain.Organizadores;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventos.IO.Domain.Eventos
{
    public class Evento : Entity<Evento>
    {
        public Evento(
            string nome,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valor,
            bool online,
            string nomeEmpresa)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Gratuito = gratuito;
            this.Valor = valor;
            this.Online = online;
            this.NomeEmpresa = nomeEmpresa;
        }

        private Evento() { }

        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public bool Excluido { get; private set; }

        public ICollection<Tags> Tags { get; private set; }

        public Guid? CategoriaId { get; private set; }
        public Guid? EnderecoId { get; private set; }
        public Guid? OrganizadorId { get; private set; }

        //EF Propriedades de Navegação
        public Categoria Categoria { get; private set; }
        public Endereco Endereco { get; private set; }
        public Organizador Organizador { get; private set; }

        public void AtribuirEndereco(Endereco endereco)
        {
            if (!endereco.EhValido())
                return;

                Endereco = endereco;
        }

        public void AtribuirCategoria(Categoria categoria)
        {
            if (!categoria.EhValido())
                return;

            Categoria = categoria;
        }

        public void ExcluirEvento()
        {
            //TODO: Deve validar alguma regra?
            Excluido = true;
        }

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        #region Validações
        private void Validar()
        {
            ValidarNome();
            ValidarValor();
            ValidarData();
            ValidarLocal();
            ValidarNomeEmpresa();
            ValidationResult = Validate(this);

            //Validações Adicionais
            ValidarEndereco();
        }

        private void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O Nome do evento precisa ser fornecido.")
                .Length(2, 150).WithMessage("o nome do evento precisa ter entre 2 e 150 caracteres");
        }

        private void ValidarValor()
        {
            if (!Gratuito)
                RuleFor(c => c.Valor)
                    .ExclusiveBetween(1, 50000).WithMessage("O valor precisa estar entre 1 e 50.000");

            if (Gratuito)
                RuleFor(c => c.Valor)
                    .LessThanOrEqualTo(0)
                    .WithMessage("para um evento Gratuito o valor não pode ser 0");
        }

        private void ValidarData()
        {
            RuleFor(c => c.DataFim)
                .GreaterThan(c => c.DataInicio)
                .WithMessage("A data de Início não deve ser maior que a data de Fim do evento");

            RuleFor(c => DateTime.Now)
                .LessThan(c => c.DataInicio)
                .WithMessage("A data de Início do evento não deve ser menor que a data atual");
        }

        private void ValidarLocal()
        {
            if (Online)
                RuleFor(c => c.Endereco)
                    .Null().When(c => c.Online)
                    .WithMessage("O evento não deve possuir um endereço se for online");

            if (!Online)
                RuleFor(c => c.Endereco)
                    .NotNull().When(c => !c.Online)
                    .WithMessage("O evento deve possuir um endereço");
        }

        private void ValidarNomeEmpresa()
        {
            RuleFor(c => c.NomeEmpresa)
                .NotEmpty().WithMessage("O Nome do Organizador precisa ser fornecido.")
                .Length(2, 150).WithMessage("o nome do Organizador precisa ter entre 2 e 150 caracteres");
        }

        private void ValidarEndereco()
        {
            if (Online) return;

            if (Endereco.EhValido()) return;

            //Adciona o erros do endereço ao validation result do Endereço
            foreach (var error in Endereco.ValidationResult.Errors)
                ValidationResult.Errors.Add(error);
        }
        #endregion

        public static class EventoFactory
        {
            public static Evento NovoEventoCompleto(Guid id,
                string nome,
                string descCurta,
                string descLonga,
                DateTime dataInicio,
                DateTime dataFim,
                bool gratuito,
                decimal valor,
                bool online,
                string nomeEmpresa,
                Guid? organizadorId,
                Endereco endereco, 
                Guid categoriaId)
            {
                var evento = new Evento()
                {
                    Id = id,
                    Nome = nome,
                    DescricaoCurta = descCurta,
                    DescricaoLonga = descLonga,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    Gratuito = gratuito,
                    Valor =  valor,
                    Online = online,
                    NomeEmpresa = nomeEmpresa,
                    Endereco = endereco,
                    CategoriaId =  categoriaId
                };

                if (organizadorId.HasValue)
                    evento.OrganizadorId = organizadorId.Value;

                if (online)
                    evento.Endereco = null;

                return evento;
            }
        }
    }
}
