using ApplicationIdentity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIdentity.Database.ModelBuilders
{
    public static class IdentityModelBuilder
    {
        public static ModelBuilder BuildIdentityModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                b.ToTable("Users");
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();

                b.ToTable("Roles");
            });

            modelBuilder.Entity<ApplicationUserRole>(b => b.ToTable("UserRoles"));
            modelBuilder.Entity<ApplicationRoleClaim>(b => b.ToTable("RoleClaims"));
            modelBuilder.Entity<ApplicationUserLogin>(b => b.ToTable("UserLogins"));
            modelBuilder.Entity<ApplicationUserToken>(b => b.ToTable("UserTokens"));
            modelBuilder.Entity<ApplicationUserClaim>(b => b.ToTable("UserClaims"));

            return modelBuilder;
        }
    }
}
