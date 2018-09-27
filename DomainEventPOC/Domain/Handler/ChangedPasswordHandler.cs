using DomainEventPOC.Domain.Events;
using DomainEventPOC.Repositories;

namespace DomainEventPOC.Domain.Handler
{
    public class ChangedPasswordHandler : IHandler<ChangedPassword>
    {
        private readonly UserRepository repo = new UserRepository();
        public void Handle(ChangedPassword args)
        {
            var userId = args.UserId;
            var newPassword = args.NewPassword;
            repo.UpdatePassword(userId, newPassword);
        }
    }
}
