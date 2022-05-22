namespace PWProj.Api.Features.Profile.RegisterProfile
{
    public class RegisterProfileCommand
    {

        public RegisterProfileCommand(string email, string name, string phoneNumber, string address)
        {
            Email = email;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string Email { get; init; }
        public string Name { get; init; }
        public string PhoneNumber { get; init; }
        public string Address { get; init; }
    }
}
