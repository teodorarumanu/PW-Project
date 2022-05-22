using PWProj.Core.DataModel;
using PWProj.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;


namespace PWProj.Infrastructure.Data
{
    public class PWProjContext : DbContext
    {
        public PWProjContext(DbContextOptions<PWProjContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NewsPostsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SheltersConfiguration).Assembly);
        }

        // 

        public DbSet<Users> Users => Set<Users>();
        public DbSet<NewsPosts> NewsPosts => Set<NewsPosts>();
        public DbSet<Shelters> Shelters => Set<Shelters>();
    }
}

