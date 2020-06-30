﻿using Eventos.IO.Domain.Core.Models;
using Eventos.IO.Domain.Eventos;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Domain.Organizadores
{
    public class Organizador : Entity<Organizador>
    {
        public Organizador(Guid id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public Organizador() { }

        public override bool EhValido()
            => true;

        public virtual ICollection<Evento> Eventos { get; set; }
    }
}