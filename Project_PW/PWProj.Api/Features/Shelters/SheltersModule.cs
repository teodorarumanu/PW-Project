using PWProj.Api.Features.Shelters.AddShelter;
using PWProj.Api.Features.Shelters.DeleteShelter;
using PWProj.Api.Features.Shelters.ViewAllShelters;

namespace PWProj.Api.Features.Shelters
{
    internal static class SheltersModule
    {
        internal static void AddSheltersHandlers(this IServiceCollection services)
        {
            services.AddTransient<IAddShelterCommandHandler, AddShelterCommandHandler>();
            services.AddTransient<IViewAllSheltersQueryHandler, ViewAllSheltersQueryHandler>();
            services.AddTransient<IDeleteShelterHandler, DeleteShelterHandler>();
        }
    }
}
