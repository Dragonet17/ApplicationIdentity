using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ApplicationIdentity.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

        public string Spetialization { get; set; }

        public Address Address { get; set; }

    }
}
