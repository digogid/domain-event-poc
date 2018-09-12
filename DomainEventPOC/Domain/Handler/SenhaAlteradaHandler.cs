using DomainEventPOC.Domain.Events;
using DomainEventPOC.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class SenhaAlteradaHandler : IHandler<SenhaAlteradaEvent>
    {
        private readonly UsuarioRepository repo = new UsuarioRepository();
        public void Handle(SenhaAlteradaEvent args)
        {
            var usuarioId = args.UsuarioId;
            var novaSenha = args.NovaSenha;
            repo.UpdatePassword(usuarioId, novaSenha);
        }
    }
}
