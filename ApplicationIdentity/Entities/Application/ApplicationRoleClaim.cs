using Microsoft.AspNetCore.Identity;
using System;

namespace ApplicationIdentity.Entities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}
