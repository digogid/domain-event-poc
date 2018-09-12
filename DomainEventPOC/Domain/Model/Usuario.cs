using DomainEventPOC.Domain.Events;
using System;

namespace DomainEventPOC.Domain.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;

            var evento = new UsuarioCriadoEvent(this);
            DomainEventManager.Raise(evento);
        }

        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
    }
}
