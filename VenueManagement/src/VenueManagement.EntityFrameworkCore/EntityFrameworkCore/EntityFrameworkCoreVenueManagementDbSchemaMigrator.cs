using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VenueManagement.Data;
using Volo.Abp.DependencyInjection;

namespace VenueManagement.EntityFrameworkCore;

public class EntityFrameworkCoreVenueManagementDbSchemaMigrator
    : IVenueManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreVenueManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the VenueManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<VenueManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
