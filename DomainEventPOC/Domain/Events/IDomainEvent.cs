using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventPOC.Domain.Events
{
    public interface IDomainEvent
    {
        DateTime DataOcorrencia { get; set; }
    }
}
