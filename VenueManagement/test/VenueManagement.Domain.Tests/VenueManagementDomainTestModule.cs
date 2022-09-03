using VenueManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VenueManagement;

[DependsOn(
    typeof(VenueManagementEntityFrameworkCoreTestModule)
    )]
public class VenueManagementDomainTestModule : AbpModule
{

}
