using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }       
        public string ImagemURL { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}
