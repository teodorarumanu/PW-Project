using PWProj.Core.Domain.NewsPost;

namespace PWProj.Api.Features.NewsPosts.AddNewsPost
{
    public record AddNewsPostCommand : InsertNewsPostCommand
    {
        public AddNewsPostCommand(string title, string description, int thumbsUpNo, int thumbsDownNo, IEnumerable<KeyWordDto> keywords) : base(title, description, thumbsUpNo, thumbsDownNo, keywords)
        {
        }
    }
}
