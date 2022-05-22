using PWProj.Api.Web;
using PWProj.Core.Domain.NewsPost;

namespace PWProj.Api.Features.NewsPosts.DeleteNewsPost
{
    public class DeleteNewsPostHandler : IDeleteNewsPostHandler
    {
        private readonly INewsPostsRepository newsPostsRepository;

        public DeleteNewsPostHandler(INewsPostsRepository newsPostsRepository)
        {
            this.newsPostsRepository = newsPostsRepository;
        }

        public async Task HandleAsync(int id, CancellationToken cancellationToken)
        {
            var newsPost = await newsPostsRepository.GetAsync(id, cancellationToken) as NewsPostsDomain;

            if (newsPost == null)
            {
                throw new ApiException(System.Net.HttpStatusCode.NotFound, $"NewsPost with id {id} was not found.");
            }

            await newsPostsRepository.DeleteNewsPostAsync(id, cancellationToken);
            await newsPostsRepository.SaveAsync(cancellationToken);

        }
    }
}
