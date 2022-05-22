using PWProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace PWProj.Api.Features.Shelters.ViewAllShelters
{
    public class ViewAllSheltersQueryHandler : IViewAllSheltersQueryHandler
    {
        private readonly PWProjContext dbContext;

        public ViewAllSheltersQueryHandler(PWProjContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ShelterDto>> HandleAsync(CancellationToken cancellationToken)
        {
            var shelters = await dbContext.Shelters
                .AsNoTracking()
                .Select(x => new ShelterDto(x.Name, x.Location, x.Capacity, x.Status, x.ContactName, x.ContactPhoneNo, x.Address))
                .ToListAsync(cancellationToken);

            return shelters;
        }
    }
}
