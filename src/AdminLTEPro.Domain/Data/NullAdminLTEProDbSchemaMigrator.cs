using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AdminLTEPro.Data
{
    /* This is used if database provider does't define
     * IAdminLTEProDbSchemaMigrator implementation.
     */
    public class NullAdminLTEProDbSchemaMigrator : IAdminLTEProDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}