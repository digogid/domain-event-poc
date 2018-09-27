using System;

namespace DomainEventPOC.Domain.Events
{
    public interface IDomainEvent
    {
        DateTime When { get; set; }
    }
}
