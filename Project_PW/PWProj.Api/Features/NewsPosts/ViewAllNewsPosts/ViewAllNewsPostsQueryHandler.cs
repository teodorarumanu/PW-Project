using PWProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace PWProj.Api.Features.NewsPosts.ViewAllNewsPosts
{
    public class ViewAllNewsPostsQueryHandler : IViewAllNewsPostsQueryHandler
    {
        private readonly PWProjContext dbContext;

        public ViewAllNewsPostsQueryHandler(PWProjContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<NewsPostDto>> HandleAsync(CancellationToken cancellationToken)
        {
            var newsPosts = await dbContext.NewsPosts
                .AsNoTracking()
                .Select(x => new NewsPostDto(x.Title, x.Description, x.ThumbsUpNo, x.ThumbsDownNo, x.Keywords))
                .ToListAsync(cancellationToken);

            return newsPosts;
        }

    }
}
