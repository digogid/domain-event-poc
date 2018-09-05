using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventPOC.Domain.Events
{
    public class DomainEventManager
    {
        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            // ioc container to get all handlers
        }
    }
}
