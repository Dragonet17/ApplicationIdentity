using Microsoft.AspNetCore.Identity;
using System;

namespace ApplicationIdentity.Entities
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
