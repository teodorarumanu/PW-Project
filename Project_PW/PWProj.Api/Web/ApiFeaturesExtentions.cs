using PWProj.Api.Features.Profile;
using PWProj.Api.Features.NewsPosts;
using PWProj.Api.Features.Shelters;
namespace PWProj.Api.Web
{
    public static class ApiFeaturesExtentions
    {
        public static void AddApiFeaturesHandlers(this IServiceCollection services)
        {
            // Add Profile Handlers
            services.AddProfilesHandlers();

            // Add NewsPost Handlers
            services.AddNewsPostsHandlers();

            // Add NewsPost Handlers
            services.AddSheltersHandlers();
        }
    }
}
