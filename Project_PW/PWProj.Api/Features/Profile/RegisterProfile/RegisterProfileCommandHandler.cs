using PWProj.Core.Domain.UserActions;

namespace PWProj.Api.Features.Profile.RegisterProfile
{
    public class RegisterProfileCommandHandler : IRegisterProfileCommandHandler
    {
        private readonly IUsersActionsRepository usersActionsRepository;

        public RegisterProfileCommandHandler(IUsersActionsRepository usersActionsRepository)
        {
            this.usersActionsRepository = usersActionsRepository;
        }
        public Task HandleAsync(RegisterProfileCommand command, string identityId, CancellationToken cancellationToken)
            => usersActionsRepository.AddAsync(
                new RegisterUserProfileCommand(identityId, command.Email, command.Name, command.PhoneNumber, command.Address),
                cancellationToken);

    }
}
