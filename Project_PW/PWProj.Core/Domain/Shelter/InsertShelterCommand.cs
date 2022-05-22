using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.Shelter
{
    public record InsertShelterCommand : ICreateAggregateCommand
    {
        public string Name { get; init; }
        public string Location { get; init; }
        public int Capacity { get; init; }
        public bool Status { get; init; }
        public string ContactName { get; init; }
        public string ContactPhoneNo { get; init; }
        public string Address { get; init; }
       

        public InsertShelterCommand(string name, string location, int capacity, bool status, string contactName, string contactPhoneNo, string address)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Status = status;
            ContactName = contactName;
            ContactPhoneNo = contactPhoneNo;
            Address = address;
        }
    }

}
