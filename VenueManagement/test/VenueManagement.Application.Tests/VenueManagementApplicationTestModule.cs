using Volo.Abp.Modularity;

namespace VenueManagement;

[DependsOn(
    typeof(VenueManagementApplicationModule),
    typeof(VenueManagementDomainTestModule)
    )]
public class VenueManagementApplicationTestModule : AbpModule
{

}
