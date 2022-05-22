using PWProj.Api.Web;
using PWProj.Core.Domain.NewsPost;
using PWProj.Core.Domain.UserActions;
using MediatR;
using System.Net;

namespace PWProj.Api.Features.NewsPosts.VotePostThumbUp
{
    public class UserVotedThumbsUpEventHandler : INotificationHandler<UserVotedPostThumbUpEvent>
    {
        private readonly INewsPostsRepository newsPostsRepository;

        public UserVotedThumbsUpEventHandler(INewsPostsRepository newsPostsRepository)
        {
            this.newsPostsRepository = newsPostsRepository;
        }

        public async Task Handle(UserVotedPostThumbUpEvent notification, CancellationToken cancellationToken)
        {
            var newsPost = await newsPostsRepository.GetAsync(notification.NewsPostId, cancellationToken) as NewsPostsDomain;

            if (newsPost == null)
            {
                throw new ApiException(HttpStatusCode.NotFound, $"NewsPost with id {notification.NewsPostId} not found!");
            }

            newsPost.MarkPostThumbUp();

            await newsPostsRepository.SaveAsync(cancellationToken);
        }
    }
}