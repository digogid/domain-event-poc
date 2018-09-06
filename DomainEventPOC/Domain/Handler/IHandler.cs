using DomainEventPOC.Domain.Events;

namespace DomainEventPOC.Domain.Handler
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
