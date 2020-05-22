using System;
using ApplicationIdentity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationIdentity.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationIdentity<T>(this IServiceCollection services, IConfiguration configuration, string connectionStringName, Action<IdentityOptions> setupAction) where T : DbContext
        {
            services.AddDbContext<T>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString(connectionStringName)));
            services.AddIdentity<ApplicationUser, ApplicationRole>(setupAction)
                .AddEntityFrameworkStores<T>()
                .AddDefaultTokenProviders();
        }
    }
}
