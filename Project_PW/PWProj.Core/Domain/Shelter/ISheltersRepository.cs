using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.Shelter
{
    public interface ISheltersRepository : IRepositoryOfAggregate<Shelters, InsertShelterCommand>
    {
        public Task DeleteShelterAsync(int ShelterId, CancellationToken cancellationToken);
    }
}
