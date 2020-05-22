using ApplicationIdentity.Database.ModelBuilders.EntitiesBuilders;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIdentity.Database.ModelBuilders
{
    public static class EntityModelBuilder
    {
        public static ModelBuilder BuildEnityModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.BuildAddressModel();
           
            return modelBuilder;
        }
    }
}
