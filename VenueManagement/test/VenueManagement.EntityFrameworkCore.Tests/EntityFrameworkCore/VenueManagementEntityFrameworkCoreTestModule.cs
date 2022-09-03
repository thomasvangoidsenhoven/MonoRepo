using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;

namespace VenueManagement.EntityFrameworkCore;

[DependsOn(
    typeof(VenueManagementEntityFrameworkCoreModule),
    typeof(VenueManagementTestBaseModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
    )]
public class VenueManagementEntityFrameworkCoreTestModule : AbpModule
{
    private SqliteConnection _sqliteConnection;

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureInMemorySqlite(context.Services);
    }

    private void ConfigureInMemorySqlite(IServiceCollection services)
    {
        _sqliteConnection = CreateDatabaseAndGetConnection();

        services.Configure<AbpDbContextOptions>(options =>
        {
            options.Configure(context =>
            {
                context.DbContextOptions.UseSqlite(_sqliteConnection);
            });
        });
    }

    public override void OnApplicationShutdown(ApplicationShutdownContext context)
    {
        _sqliteConnection.Dispose();
    }

    private static SqliteConnection CreateDatabaseAndGetConnection()
    {
        var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        var options = new DbContextOptionsBuilder<VenueManagementDbContext>()
            .UseSqlite(connection)
            .Options;

        using (var context = new VenueManagementDbContext(options))
        {
            context.GetService<IRelationalDatabaseCreator>().CreateTables();
        }

        return connection;
    }
}
