using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace AdminLTEPro.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See AdminLTEProDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class AdminLTEProMigrationsDbContext : AbpDbContext<AdminLTEProMigrationsDbContext>
    {
        public AdminLTEProMigrationsDbContext(DbContextOptions<AdminLTEProMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer((opts) =>
            {
                // DOTO: IdentityServer 需要设定数据提供者
                opts.DatabaseProvider = EfCoreDatabaseProvider.MySql;
            });
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure customizations for entities from the modules included  */

            builder.Entity<IdentityUser>(b =>
            {
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureAdminLTEPro method */

            builder.ConfigureAdminLTEPro();
        }
    }
}