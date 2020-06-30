using Eventos.IO.Domain.Core.Models;
using FluentValidation;
using System;

namespace Eventos.IO.Domain.Eventos
{
    public class Endereco : Entity<Endereco>
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid? EventoId { get; private set; }

        //EF Propriedade de Navegacao
        public virtual Evento Evento { get; private set;}

        public Endereco(
            Guid id,
            string logradouro, 
            string numero, 
            string bairro, 
            string cep, 
            string complemento,
            string cidade,
            string estado,
            Guid? eventoId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            EventoId = eventoId;
        }

        public Endereco() {  }

        public override bool EhValido()
        {
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("O Logradouro precisa ser fornecido")
                .Length(2, 150).WithMessage("O Logradouro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Numero )
                .NotEmpty().WithMessage("O Numero  precisa ser fornecido")
                .Length(2, 20).WithMessage("O Numero  precisa ter entre 2 e 20 caracteres");

            RuleFor(c => c.Bairro )
                .NotEmpty().WithMessage("O Bairro  precisa ser fornecido")
                .Length(2, 50).WithMessage("O Bairro  precisa ter entre 2 e 50 caracteres");

            RuleFor(c => c.CEP )
                .NotEmpty().WithMessage("O CEP  precisa ser fornecido")
                .Length(8).WithMessage("O CEP  precisa ter entre 8 caracteres");

            //RuleFor(c => c.Complemento)
            //    .NotEmpty().WithMessage("O Complemento precisa ser fornecido")
            //    .Length(2, 100).WithMessage("O Complemento precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("O Cidade precisa ser fornecido")
                .Length(2, 100).WithMessage("O Cidade precisa ter entre 2 e 100 caracteres");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O Estado precisa ser fornecido")
                .Length(2, 100).WithMessage("O Estado precisa ter entre 2 e 100 caracteres");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}