using PWProj.Core.DataModel;

namespace PWProj.Api.Features.NewsPosts.ViewAllNewsPosts
{
    public record NewsPostDto
    {
        public NewsPostDto(string title, string description, int thumbsUpNo, int thumbsDownNo, ICollection<Keywords> keywords)
        {
            Title = title;
            Description = description;
            ThumbsUpNo = thumbsUpNo;
            ThumbsDownNo = thumbsDownNo;
            Keywords = keywords;
        }

        public string Title { get; init; }
        public string Description { get; init; }
        public int ThumbsUpNo { get; init; }
        public int ThumbsDownNo { get; init; }
        public virtual ICollection<Keywords> Keywords { get; init; } = new List<Keywords>();
    }
}
