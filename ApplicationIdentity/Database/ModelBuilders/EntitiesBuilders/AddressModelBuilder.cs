using ApplicationIdentity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIdentity.Database.ModelBuilders.EntitiesBuilders
{
    public static class AddressModelBuilder
    {
        public static ModelBuilder BuildAddressModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(b =>
            {
                b.HasKey(a => a.Id);
                b.HasOne(c => c.User)
                    .WithOne(x => x.Address);
            });

            return modelBuilder;
        }
    }
}
