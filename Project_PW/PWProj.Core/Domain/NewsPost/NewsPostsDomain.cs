using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;
using System.Collections.Generic;

namespace PWProj.Core.Domain.NewsPost
{
    public class NewsPostsDomain : DomainOfAggregate<NewsPosts>
    {
        public NewsPostsDomain(NewsPosts aggregate) : base(aggregate)
        {
        }

        public void UpdateNewsPost(string title, string description, int thumbsUpNo, int thumbsDownNo, ICollection<Keywords> keywords)
        {
            aggregate.Title = title;
            aggregate.Description = description;
            aggregate.ThumbsUpNo = thumbsUpNo;
            aggregate.ThumbsDownNo = thumbsDownNo;
            aggregate.Keywords = keywords;
        }

        
        public void MarkPostThumbUp() => aggregate.ThumbsUpNo += 1;
        public void MarkPostThumbDown() => aggregate.ThumbsDownNo += 1;
        
    }
}
