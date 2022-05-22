using PWProj.Api.Features.Profile.RegisterProfile;
using PWProj.Api.Features.Profile.ViewProfile;

namespace PWProj.Api.Features.Profile
{
    internal static class ProfilesModule
    {
        internal static void AddProfilesHandlers(this IServiceCollection services)
        {
            services.AddTransient<IRegisterProfileCommandHandler, RegisterProfileCommandHandler>();
            services.AddTransient<IViewProfileQueryHandler, ViewProfileQueryHandler>();
        }
    }
}
