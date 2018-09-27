using DomainEventPOC.Domain.Events;
using System;

namespace DomainEventPOC.Domain.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;

            var @event = new UserCreated(this);
            DomainEventManager.Raise(@event);
        }

        public void UpdatePassword(string newPassword)
        {
            Password = newPassword;
            var @event = new ChangedPassword(this.Id, newPassword);
            DomainEventManager.Raise(@event);
        }
    }
}
