using DomainEventPOC.Domain.Events;
using DomainEventPOC.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class UsuarioCriadoHandler : IHandler<UsuarioCriadoEvent>
    {
        private readonly UsuarioRepository repo = new UsuarioRepository();
        public void Handle(UsuarioCriadoEvent args)
        {
            var usuario = args.Usuario;
            repo.AddAsync(usuario);
        }
    }
}
