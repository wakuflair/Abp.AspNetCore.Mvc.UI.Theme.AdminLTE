using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AdminLTEPro.EntityFrameworkCore
{
    public static class AdminLTEProDbContextModelCreatingExtensions
    {
        public static void ConfigureAdminLTEPro(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AdminLTEProConsts.DbTablePrefix + "YourEntities", AdminLTEProConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}