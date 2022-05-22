using PWProj.Core.SeedWork;
using System.Collections.Generic;

namespace PWProj.Core.Domain.NewsPost
{
    public record InsertNewsPostCommand : ICreateAggregateCommand
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public int ThumbsUpNo { get; init; }
        public int ThumbsDownNo { get; init; }
        public IEnumerable<KeyWordDto> Keywords { get; init; } = new List<KeyWordDto>();

        public InsertNewsPostCommand(string title, string description, int thumbsUpNo, int thumbsDownNo, IEnumerable<KeyWordDto> keywords)
        {
            Title = title;
            Description = description;
            ThumbsUpNo = thumbsUpNo;
            ThumbsDownNo = thumbsDownNo;
            Keywords = keywords;
        }
    }

    public record KeyWordDto(string Name, string Description);
}
