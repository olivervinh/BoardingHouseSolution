using BoardingHouse.Domain.HouseDomain.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace BoardingHouse.Domain.UserDomain.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<House> Houses { get; set; }
    }
}
