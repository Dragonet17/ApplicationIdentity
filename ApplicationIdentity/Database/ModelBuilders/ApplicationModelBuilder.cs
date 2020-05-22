using ApplicationIdentity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIdentity.Database.ModelBuilders
{
    public static class ApplicationModelBuilder
    {
        public static void BuildApplicationModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.BuildIdentityModel()
                        .BuildEnityModel();
        }
    }
}
