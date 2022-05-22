using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.NewsPost
{
    public interface INewsPostsRepository : IRepositoryOfAggregate<NewsPosts, InsertNewsPostCommand>
    {
        public Task DeleteNewsPostAsync(int NewsPostId, CancellationToken cancellationToken);
    }
}
