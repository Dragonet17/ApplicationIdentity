using ApplicationIdentity.Database.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationIdentity.Extensions
{
    public static  class MigrationManager
    {
        public static void UpdateDatabase<T>(this IApplicationBuilder app) where T: DbContext
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<T> ();
            context.Database.Migrate();
        }
    }
}
