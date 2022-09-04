using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VenueManagement.Data;

/* This is used if database provider does't define
 * IVenueManagementDbSchemaMigrator implementation.
 */
public class NullVenueManagementDbSchemaMigrator : IVenueManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
