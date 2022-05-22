using PWProj.Core.Domain.Shelter;

namespace PWProj.Api.Features.Shelters.AddShelter
{
    public class AddShelterCommandHandler : IAddShelterCommandHandler
    {
        private readonly ISheltersRepository sheltersRepository;

        public AddShelterCommandHandler(ISheltersRepository sheltersRepository)
        {
            this.sheltersRepository = sheltersRepository;
        }

        public Task HandleAsync(AddShelterCommand command, CancellationToken cancellationToken)
            => sheltersRepository.AddAsync(
                new InsertShelterCommand(command.Name, command.Location, command.Capacity, command.Status, command.ContactName, command.ContactPhoneNo, command.Address), cancellationToken);

    }
}
