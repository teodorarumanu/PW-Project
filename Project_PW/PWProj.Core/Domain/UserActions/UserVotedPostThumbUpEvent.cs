using MediatR;

namespace PWProj.Core.Domain.UserActions
{
    public record UserVotedPostThumbUpEvent : INotification
    {
        public int NewsPostId { get; private set; }
        public UserVotedPostThumbUpEvent(int newsPostId)
        {
            NewsPostId = newsPostId;
        }
    }
}
