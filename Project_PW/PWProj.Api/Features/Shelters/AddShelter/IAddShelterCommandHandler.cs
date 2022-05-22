using PWProj.Core.Domain;

namespace PWProj.Api.Features.Shelters.AddShelter
{
    public interface IAddShelterCommandHandler
    {
        public Task HandleAsync(AddShelterCommand command, CancellationToken cancellation);
    }
}
