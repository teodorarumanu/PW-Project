using PWProj.Api.Features.Profile.RegisterProfile;

namespace PWProj.Api.Features.Profile.ViewProfile
{
    public class ProfileDto : RegisterProfileCommand
    {
        public ProfileDto(string email, string name, string phoneNumber, string address) : base(email, name, phoneNumber, address)
        {
        }
    }
}
