using Volo.Abp.Modularity;

namespace AdminLTEPro
{
    [DependsOn(
        typeof(AdminLTEProApplicationModule),
        typeof(AdminLTEProDomainTestModule)
        )]
    public class AdminLTEProApplicationTestModule : AbpModule
    {

    }
}