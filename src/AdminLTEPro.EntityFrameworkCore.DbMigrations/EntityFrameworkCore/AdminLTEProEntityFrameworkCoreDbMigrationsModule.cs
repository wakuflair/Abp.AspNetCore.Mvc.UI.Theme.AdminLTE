using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AdminLTEPro.EntityFrameworkCore
{
    [DependsOn(
        typeof(AdminLTEProEntityFrameworkCoreModule)
        )]
    public class AdminLTEProEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AdminLTEProMigrationsDbContext>();
        }
    }
}
