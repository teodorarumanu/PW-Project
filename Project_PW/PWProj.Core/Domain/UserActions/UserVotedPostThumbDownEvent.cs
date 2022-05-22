using MediatR;

namespace PWProj.Core.Domain.UserActions
{
    public record UserVotedPostThumbDownEvent : INotification
    {
        public int NewsPostId { get; private set; }
        public UserVotedPostThumbDownEvent(int newsPostId)
        {
            NewsPostId = newsPostId;
        }
    }
}
