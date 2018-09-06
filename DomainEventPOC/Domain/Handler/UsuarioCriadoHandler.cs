using DomainEventPOC.Domain.Events;
using DomainEventPOC.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class UsuarioCriadoHandler : IHandler<EventoUsuarioCriado>
    {
        private readonly UsuarioRepository repo = new UsuarioRepository();
        public void Handle(EventoUsuarioCriado args)
        {
            var usuario = args.Usuario;
            repo.AddAsync(usuario);
        }
    }
}
