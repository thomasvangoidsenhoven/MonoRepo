using System;
using System.Collections.Generic;
using System.Text;
using VenueManagement.Localization;
using Volo.Abp.Application.Services;

namespace VenueManagement;

/* Inherit your application services from this class.
 */
public abstract class VenueManagementAppService : ApplicationService
{
    protected VenueManagementAppService()
    {
        LocalizationResource = typeof(VenueManagementResource);
    }
}
