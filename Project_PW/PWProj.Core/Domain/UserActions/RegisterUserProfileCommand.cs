using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.UserActions
{
    public record RegisterUserProfileCommand : ICreateAggregateCommand
    {
        public RegisterUserProfileCommand(string identityId, string email, string name, string phoneNumber, string address)
        {
            IdentityId = identityId;
            Email = email;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string IdentityId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
