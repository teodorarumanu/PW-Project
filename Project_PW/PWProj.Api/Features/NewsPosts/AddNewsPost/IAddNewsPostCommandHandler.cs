using PWProj.Core.Domain;

namespace PWProj.Api.Features.NewsPosts.AddNewsPost
{
    public interface IAddNewsPostCommandHandler
    {
        public Task HandleAsync(AddNewsPostCommand command, CancellationToken cancellation);

    }
}
