using DomainEventPOC.Domain.Events;
using DomainEventPOC.Interfaces.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class UserCreatedHandler : IHandler<UserCreated>
    {
        private readonly IUserRepository _repository;

        public UserCreatedHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Handle(UserCreated args)
        {
            var user = args.User;
            _repository.AddAsync(user);
        }
    }
}
