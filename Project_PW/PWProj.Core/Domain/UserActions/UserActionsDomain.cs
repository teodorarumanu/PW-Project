using PWProj.Core.DataModel;
using PWProj.Core.SeedWork;

namespace PWProj.Core.Domain.UserActions
{
    public class UsersActionsDomain : DomainOfAggregate<Users>
    {
        public UsersActionsDomain(Users aggregate) : base(aggregate)
        {
        }

        public void UpdateProfile(string name, string email, string phone, string address)
        {
            aggregate.Name = name;
            aggregate.Email = email;
            aggregate.PhoneNumber = phone;
            aggregate.Address = address;
        }

        // add events ??

        public int GetProfileId() => aggregate.Id;
    }
}
