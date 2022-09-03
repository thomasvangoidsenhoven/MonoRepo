using VenueManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace VenueManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VenueManagementEntityFrameworkCoreModule),
    typeof(VenueManagementApplicationContractsModule)
    )]
public class VenueManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
