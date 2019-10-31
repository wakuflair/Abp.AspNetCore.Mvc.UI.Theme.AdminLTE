using System.Threading.Tasks;

namespace AdminLTEPro.Data
{
    public interface IAdminLTEProDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
