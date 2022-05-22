using PWProj.Core.DataModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PWProj.Infrastructure.Data.EntityConfigurations
{
    internal class SheltersConfiguration : EntityConfiguration<Shelters>
    {
        public override void Configure(EntityTypeBuilder<Shelters> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
                .Property(x => x.Location)
                .IsRequired();

            builder
                .Property(x => x.Capacity)
                .IsRequired();

            builder
                .Property(x => x.ContactName)
                .IsRequired();

            builder
                .Property(x => x.ContactPhoneNo)
                .IsRequired();

            base.Configure(builder);
        }
    }
}
