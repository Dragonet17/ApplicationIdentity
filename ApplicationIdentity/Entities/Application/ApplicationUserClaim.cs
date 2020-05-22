using Microsoft.AspNetCore.Identity;
using System;

namespace ApplicationIdentity.Entities
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
