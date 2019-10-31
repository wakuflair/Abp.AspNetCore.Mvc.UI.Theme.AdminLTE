using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminLTEPro.Data;
using Volo.Abp.DependencyInjection;

namespace AdminLTEPro.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAdminLTEProDbSchemaMigrator 
        : IAdminLTEProDbSchemaMigrator, ITransientDependency
    {
        private readonly AdminLTEProMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAdminLTEProDbSchemaMigrator(AdminLTEProMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}