using System;

namespace DomainEventPOC.Domain.Events
{
    public class ChangedPassword : IDomainEvent
    {
        public Guid UserId { get; set; }
        public string NewPassword { get; set; }
        public DateTime When { get; set; }

        public ChangedPassword(Guid userId, string newPassword)
        {
            UserId = userId;
            NewPassword = newPassword;
            When = DateTime.Now;
        }
    }
}
