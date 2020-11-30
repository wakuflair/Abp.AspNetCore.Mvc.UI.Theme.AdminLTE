using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AdminLTEPro.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AdminLTEProMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdminLTEProMigrationsDbContext>
    {
        public AdminLTEProMigrationsDbContext CreateDbContext(string[] args)
        {
            AdminLTEProEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AdminLTEProMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AdminLTEProMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AdminLTEPro.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
