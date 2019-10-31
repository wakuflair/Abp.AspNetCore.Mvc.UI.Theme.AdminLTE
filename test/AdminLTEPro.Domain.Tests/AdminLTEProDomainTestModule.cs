using AdminLTEPro.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AdminLTEPro
{
    [DependsOn(
        typeof(AdminLTEProEntityFrameworkCoreTestModule)
        )]
    public class AdminLTEProDomainTestModule : AbpModule
    {

    }
}