using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWProj.Core.DataModel;
using PWProj.Core.Domain.Shelter;
using PWProj.Core.SeedWork;
using Microsoft.EntityFrameworkCore;

namespace PWProj.Infrastructure.Data.Repositories
{
    public class SheltersRepository : ISheltersRepository
    {
        private readonly PWProjContext context;

        public SheltersRepository(PWProjContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(InsertShelterCommand command, CancellationToken cancellationToken)
        {
            

            var shelter = new Shelters(command.Name, command.Location, command.Capacity, command.Status, command.ContactName, command.ContactPhoneNo, command.Address);
        

            await context.Shelters.AddAsync(shelter, cancellationToken);
            await SaveAsync(cancellationToken);
        }

        public async Task<DomainOfAggregate<Shelters>?> GetAsync(int aggregateId, CancellationToken cancellationToken)
        {
            var shelter = await context.Shelters
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (shelter == null)
            {
                return null;
            }

            return new SheltersDomain(shelter);
        }

        public async Task DeleteShelterAsync(int aggregateId, CancellationToken cancellationToken)
        {
            var shelter = await context.Shelters
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (shelter != null)
            {
                context.Shelters.Remove(shelter);
            }
        }

        public Task SaveAsync(CancellationToken cancellationToken)
        {
            return context.SaveChangesAsync(cancellationToken);
        }
    }
}
