using System;

namespace DomainEventPOC.Domain.Events
{
    public class SenhaAlteradaEvent : IDomainEvent
    {
        public Guid UsuarioId { get; set; }
        public string NovaSenha { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public SenhaAlteradaEvent(Guid usuarioId, string novaSenha)
        {
            UsuarioId = usuarioId;
            NovaSenha = novaSenha;
            DataOcorrencia = DateTime.Now;
        }
    }
}
