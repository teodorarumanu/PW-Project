using PWProj.Core.Domain.UserActions;
using PWProj.Core.Domain.NewsPost;
using PWProj.Infrastructure.Data;
using PWProj.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using PWProj.Core.Domain.Shelter;

namespace PWProj.Api.Infrastructure
{
    public static partial class DataAccessExtensions
    {

        public static void AddPWProjDbContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<PWProjContext>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("PWProjDb")));
        }

        public static void AddPWProjAggregateRepositories(this IServiceCollection services)
        {
            services.AddTransient<INewsPostsRepository, NewsPostsRepository>();
            services.AddTransient<ISheltersRepository, SheltersRepository>();
            services.AddTransient<IUsersActionsRepository, UserActionsRepository>();
        }

    }
}
