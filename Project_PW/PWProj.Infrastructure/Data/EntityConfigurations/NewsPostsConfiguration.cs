using PWProj.Core.DataModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PWProj.Infrastructure.Data.EntityConfigurations
{
    internal class NewsPostsConfiguration : EntityConfiguration<NewsPosts>
    {
        public override void Configure(EntityTypeBuilder<NewsPosts> builder)
        {
            builder
                .Property(x => x.Title)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .IsRequired();

            builder
                .OwnsMany(x => x.Keywords);

            base.Configure(builder);
        }
    }
}
