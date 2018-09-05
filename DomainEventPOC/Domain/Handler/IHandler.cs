using DomainEventPOC.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventPOC.Domain.Handler
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
