using VenueManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VenueManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VenueManagementController : AbpControllerBase
{
    protected VenueManagementController()
    {
        LocalizationResource = typeof(VenueManagementResource);
    }
}
