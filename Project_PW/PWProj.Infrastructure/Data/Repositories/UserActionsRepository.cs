using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PWProj.Core.DataModel;
using PWProj.Core.Domain;
using PWProj.Core.Domain.UserActions;
using PWProj.Core.SeedWork;
using Microsoft.EntityFrameworkCore;

namespace PWProj.Infrastructure.Data.Repositories
{
    public class UserActionsRepository : IUsersActionsRepository
    {

        private readonly PWProjContext context;

        public UserActionsRepository(PWProjContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(RegisterUserProfileCommand command, CancellationToken cancellationToken)
        {
            var user = new Users(command.IdentityId, command.Email, command.Name, command.PhoneNumber, command.Address);

            await context.Users.AddAsync(user);
            await SaveAsync(cancellationToken);
        }

        public async Task<DomainOfAggregate<Users>?> GetAsync(int aggregateId, CancellationToken cancellationToken)
        {
            
            var entity = await context.Users
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (entity == null)
            {
                return null;
            }

            return new UsersActionsDomain(entity);
        }

        public async Task<DomainOfAggregate<Users>?> GetByIdentityAsync(string identityId, CancellationToken cancellationToken)
        {
            var entity = await context.Users
                .FirstOrDefaultAsync(x => x.IdentityId == identityId, cancellationToken);

            if (entity == null)
            {
                return null;
            }

            return new UsersActionsDomain(entity);
        }

        public async Task<DomainOfAggregate<Users>?> GetWithoutActionsAsync(int aggregateId, CancellationToken cancellationToken)
        {
            var entity = await context.Users
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (entity == null)
            {
                return null;
            }

            return new UsersActionsDomain(entity);
        }

        public async Task<DomainOfAggregate<Users>?> GetByIdentityWithoutActionsAsync(string identityId, CancellationToken cancellationToken)
        {
            var entity = await context.Users
                .FirstOrDefaultAsync(x => x.IdentityId == identityId, cancellationToken);

            if (entity == null)
            {
                return null;
            }

            return new UsersActionsDomain(entity);
        }



        public Task SaveAsync(CancellationToken cancellationToken) => context.SaveChangesAsync(cancellationToken);

    }
}
