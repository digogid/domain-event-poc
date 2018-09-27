using DomainEventPOC.Domain.Model;
using System;

namespace DomainEventPOC.Domain.Events
{
    public class UserCreated : IDomainEvent
    {
        public User User { get; set; }
        public DateTime When { get; set; }

        public UserCreated(User user)
        {
            User = user;
            When = DateTime.Now;
        }
    }
}
