using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.Shelter
{
    public class SheltersDomain : DomainOfAggregate<Shelters>
    {
        public SheltersDomain(Shelters aggregate) : base(aggregate)
        {
        }

        public void UpdateShelter(string name, string location, int capacity, bool status, string contactName, string contactPhoneNo, string address)
        {
            aggregate.Name = name;
            aggregate.Location = location;
            aggregate.Capacity = capacity;
            aggregate.Status = status;
            aggregate.ContactName = contactName;
            aggregate.ContactPhoneNo = contactPhoneNo;
            aggregate.Address = address;
        }


        // mark shelter status ??

    }
}
