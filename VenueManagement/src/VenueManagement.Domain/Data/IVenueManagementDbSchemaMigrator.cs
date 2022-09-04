using System.Threading.Tasks;

namespace VenueManagement.Data;

public interface IVenueManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
