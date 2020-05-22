using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ApplicationIdentity.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {

        public ApplicationRole(string name) : base(name)
        {
        }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }

}
