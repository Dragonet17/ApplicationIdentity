using Microsoft.AspNetCore.Identity;
using System;

namespace ApplicationIdentity.Entities
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
