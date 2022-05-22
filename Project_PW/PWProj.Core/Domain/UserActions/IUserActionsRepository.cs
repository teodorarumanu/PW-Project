using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.UserActions
{
    public interface IUsersActionsRepository : IRepositoryOfAggregate<Users, RegisterUserProfileCommand>
    {
        public Task<DomainOfAggregate<Users>?> GetByIdentityAsync(string identityId, CancellationToken cancellationToken);
        public Task<DomainOfAggregate<Users>?> GetWithoutActionsAsync(int id, CancellationToken cancellationToken);
        public Task<DomainOfAggregate<Users>?> GetByIdentityWithoutActionsAsync(string identityId, CancellationToken cancellationToken);

    }
}
