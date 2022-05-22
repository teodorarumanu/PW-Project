using PWProj.Core.SeedWork;

namespace PWProj.Core.DataModel
{
    public class Shelters : Entity, IAggregateRoot
    {
        public Shelters(string name, string location, int capacity, bool status, string contactName, string contactPhoneNo, string address)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Status = status;
            ContactName = contactName;
            ContactPhoneNo = contactPhoneNo;
            Address = address;
        }

        
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNo { get; set; }
    }
}