using DomainEventPOC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventPOC.Domain.Events
{
    public class UsuarioCriadoEvent : IDomainEvent
    {
        public Usuario Usuario { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public UsuarioCriadoEvent(Usuario usuario)
        {
            Usuario = usuario;
            DataOcorrencia = DateTime.Now;
        }
    }
}
