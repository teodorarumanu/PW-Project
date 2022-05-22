using PWProj.Api.Web;
using PWProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace PWProj.Api.Features.Profile.ViewProfile
{
    public class ViewProfileQueryHandler : IViewProfileQueryHandler
    {
        private readonly PWProjContext dbContext;

        public ViewProfileQueryHandler(PWProjContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ProfileDto> HandleAsync(string identityId, CancellationToken cancellationToken)
        {
            var userProfile = await dbContext.Users
                .Where(x => x.IdentityId == identityId)
                .Select(x => new ProfileDto(x.Email, x.Name, x.PhoneNumber, x.Address))
                .FirstOrDefaultAsync(cancellationToken);

            if (userProfile == null)
            {
                throw new ApiException(System.Net.HttpStatusCode.Unauthorized, "This user does not have a registered profile!");
            }

            return userProfile;
        }
    }
}
