using PWProj.Core.SeedWork;
using System.Collections.Generic;

namespace PWProj.Core.DataModel
{
    public class NewsPosts : Entity, IAggregateRoot
    {
        public NewsPosts(string title, string description, int thumbsUpNo, int thumbsDownNo)
        {
            Title = title;
            Description = description;
            ThumbsUpNo = thumbsUpNo;
            ThumbsDownNo = thumbsDownNo;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int ThumbsUpNo { get; set; }
        public int ThumbsDownNo { get; set; }
        public virtual ICollection<Keywords> Keywords { get; set; } = new List<Keywords>();
    }
}