using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PWProj.Core.DataModel;
using PWProj.Core.Domain.NewsPost;
using PWProj.Core.SeedWork;
using Microsoft.EntityFrameworkCore;



namespace PWProj.Infrastructure.Data.Repositories
{
    public class NewsPostsRepository : INewsPostsRepository
    {
        private readonly PWProjContext context;

        public NewsPostsRepository(PWProjContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(InsertNewsPostCommand command, CancellationToken cancellationToken)
        {
            var keywords = command.Keywords.Select(x => new Keywords(x.Name, x.Description)).ToList();

            var newsPost = new NewsPosts(command.Title, command.Description, command.ThumbsUpNo, command.ThumbsDownNo);
            newsPost.Keywords = keywords;

            await context.NewsPosts.AddAsync(newsPost, cancellationToken);
            await SaveAsync(cancellationToken);
        }

        public async Task<DomainOfAggregate<NewsPosts>?> GetAsync(int aggregateId, CancellationToken cancellationToken)
        {
            var newsPost = await context.NewsPosts
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (newsPost == null)
            {
                return null;
            }

            return new NewsPostsDomain(newsPost);
        }

        public async Task DeleteNewsPostAsync(int aggregateId, CancellationToken cancellationToken)
        {
            var newsPost = await context.NewsPosts
                .FirstOrDefaultAsync(x => x.Id == aggregateId, cancellationToken);

            if (newsPost != null)
            {
                context.NewsPosts.Remove(newsPost);
            }
        }

        public Task SaveAsync(CancellationToken cancellationToken)
        {
            return context.SaveChangesAsync(cancellationToken);
        }
    }
}
