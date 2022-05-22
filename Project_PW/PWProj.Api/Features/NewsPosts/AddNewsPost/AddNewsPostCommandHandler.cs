using PWProj.Core.Domain.NewsPost;

namespace PWProj.Api.Features.NewsPosts.AddNewsPost
{
    public class AddNewsPostCommandHandler : IAddNewsPostCommandHandler
    {
        private readonly INewsPostsRepository newsPostsRepository;

        public AddNewsPostCommandHandler(INewsPostsRepository newsPostsRepository)
        {
            this.newsPostsRepository = newsPostsRepository;
        }

        public Task HandleAsync(AddNewsPostCommand command, CancellationToken cancellationToken)
            => newsPostsRepository.AddAsync(
                new InsertNewsPostCommand(command.Title, command.Description, command.ThumbsUpNo, command.ThumbsDownNo, command.Keywords), cancellationToken);
    }
}
