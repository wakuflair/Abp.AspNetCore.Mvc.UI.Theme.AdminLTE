using AdminLTEPro.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AdminLTEPro.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AdminLTEProEntityFrameworkCoreDbMigrationsModule),
        typeof(AdminLTEProApplicationContractsModule)
        )]
    public class AdminLTEProDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
