namespace PWProj.Api.Features.Shelters.ViewAllShelters
{
    public interface IViewAllSheltersQueryHandler
    {
        public Task<IEnumerable<ShelterDto>> HandleAsync(CancellationToken cancellationToken);
    }
}
