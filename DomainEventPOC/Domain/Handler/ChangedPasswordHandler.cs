using DomainEventPOC.Domain.Events;
using DomainEventPOC.Interfaces.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class ChangedPasswordHandler : IHandler<ChangedPassword>
    {
        private readonly IUserRepository _repository;
        public ChangedPasswordHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Handle(ChangedPassword args)
        {
            var userId = args.UserId;
            var newPassword = args.NewPassword;
            _repository.UpdatePassword(userId, newPassword);
        }
    }
}
