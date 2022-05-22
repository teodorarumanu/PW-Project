using PWProj.Api.Web;
using PWProj.Core.Domain.Shelter;

namespace PWProj.Api.Features.Shelters.DeleteShelter
{
    public class DeleteShelterHandler : IDeleteShelterHandler
    {
        private readonly ISheltersRepository sheltersRepository;

        public DeleteShelterHandler(ISheltersRepository sheltersRepository)
        {
            this.sheltersRepository = sheltersRepository;
        }

        public async Task HandleAsync(int id, CancellationToken cancellationToken)
        {
            var shelters = await sheltersRepository.GetAsync(id, cancellationToken) as SheltersDomain;

            if (shelters == null)
            {
                throw new ApiException(System.Net.HttpStatusCode.NotFound, $"Shelter with id {id} was not found.");
            }

            await sheltersRepository.DeleteShelterAsync(id, cancellationToken);
            await sheltersRepository.SaveAsync(cancellationToken);

        }
    }
}
