using DomainEventPOC.Domain.Handler;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace DomainEventPOC.Domain.Events
{
    public class DomainEventManager
    {
        public static IServiceProvider ServiceProvider;

        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            var handlers = ServiceProvider.GetServices(typeof(IHandler<T>)) as IEnumerable<IHandler<T>>;
            
            foreach(var handler in handlers)
            {
                handler.Handle(@event);
            }
        }
    }
}
