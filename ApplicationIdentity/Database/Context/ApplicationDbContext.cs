using System;
using System.Threading;
using System.Threading.Tasks;
using ApplicationIdentity.Database.ModelBuilders;
using ApplicationIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIdentity.Database.Context
{
    public class ApplicationDbContext<T> : IdentityDbContext<
        ApplicationUser,
        ApplicationRole,
        Guid,
        ApplicationUserClaim,
        ApplicationUserRole,
        ApplicationUserLogin,
        ApplicationRoleClaim,
        ApplicationUserToken>
    where T : DbContext
    {
        protected ApplicationDbContext(DbContextOptions<T> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.BuildApplicationModel();
        }

        public override Task<int> SaveChangesAsync(CancellationToken token = default(CancellationToken)) =>
            base.SaveChangesAsync(true, token);
    }
}
