using DomainEventPOC.Domain.Events;
using DomainEventPOC.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class UserCreatedHandler : IHandler<UserCreated>
    {
        private readonly UserRepository repo = new UserRepository();
        public void Handle(UserCreated args)
        {
            var user = args.User;
            repo.AddAsync(user);
        }
    }
}
