using PWProj.Core.DataModel;

namespace PWProj.Api.Features.Shelters.ViewAllShelters
{
    public record ShelterDto
    {

        public ShelterDto(string name, string location, int capacity, bool status, string contactName, string contactPhoneNo, string address)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Status = status;
            ContactName = contactName;
            ContactPhoneNo = contactPhoneNo;
            Address = address;
        }


        public string Name { get; init; }
        public string Location { get; init; }
        public int Capacity { get; init; }
        public string Address { get; init; }
        public bool Status { get; init; }
        public string ContactName { get; init; }
        public string ContactPhoneNo { get; init; }
    }
}
