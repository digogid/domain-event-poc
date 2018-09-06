using DomainEventPOC.Domain.Events;
using System;

namespace DomainEventPOC.Domain.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        // ef .ctor
        internal Usuario()
        {

        }

        public Usuario(string nome, string email)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            var evento = new EventoUsuarioCriado(this);
            DomainEventManager.Raise(evento);
        }
    }
}
