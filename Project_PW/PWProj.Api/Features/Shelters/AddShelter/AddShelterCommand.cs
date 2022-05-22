using PWProj.Core.Domain.Shelter;

namespace PWProj.Api.Features.Shelters.AddShelter
{
    public record AddShelterCommand : InsertShelterCommand
    {
        public AddShelterCommand(string name, string location, int capacity, bool status, string contactName, string contactPhoneNo, string address) : base(name, location, capacity, status, contactName, contactPhoneNo, address)
        {
        }
    }
}
