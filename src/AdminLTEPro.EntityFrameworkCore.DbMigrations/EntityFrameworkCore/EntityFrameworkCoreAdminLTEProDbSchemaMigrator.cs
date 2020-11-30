using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AdminLTEPro.Data;
using Volo.Abp.DependencyInjection;

namespace AdminLTEPro.EntityFrameworkCore
{
    public class EntityFrameworkCoreAdminLTEProDbSchemaMigrator
        : IAdminLTEProDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAdminLTEProDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AdminLTEProMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AdminLTEProMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}