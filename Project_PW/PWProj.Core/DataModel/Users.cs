using PWProj.Core.SeedWork;
using System.Collections.Generic;

namespace PWProj.Core.DataModel
{
    public class Users : Entity, IAggregateRoot
    {
        public Users(string identityId, string email, string name, string phoneNumber, string address)
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
        public ICollection<NewsPosts> NewsPosts { get; set; } = new List<NewsPosts>();
        public ICollection<Shelters> Shelters { get; set; } = new List<Shelters>();
    }
}

