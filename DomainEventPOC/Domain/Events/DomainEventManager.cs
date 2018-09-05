using DomainEventPOC.Domain.Handler;
using System.Collections.Generic;

namespace DomainEventPOC.Domain.Events
{
    public class DomainEventManager<T> where T : IDomainEvent
    {
        public static IEnumerable<IHandler<T>> _handlers;

        public static void Raise(T @event)
        {
            foreach(var handler in _handlers)
            {
                handler.Handle(@event);
            }
        }
    }
}
