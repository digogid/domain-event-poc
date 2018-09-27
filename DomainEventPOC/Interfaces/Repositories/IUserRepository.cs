using DomainEventPOC.Domain.Model;
using System;

namespace DomainEventPOC.Interfaces.Repositories
{
    public interface IUserRepository
    {
        void AddAsync(User user);
        void UpdatePassword(Guid userId, string newPassword);
    }
}
