using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AdminLTEPro.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AdminLTEProHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AdminLTEProConsoleApiClientModule : AbpModule
    {
        
    }
}
