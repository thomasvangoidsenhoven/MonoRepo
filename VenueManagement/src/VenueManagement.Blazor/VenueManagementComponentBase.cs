using VenueManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace VenueManagement.Blazor;

public abstract class VenueManagementComponentBase : AbpComponentBase
{
    protected VenueManagementComponentBase()
    {
        LocalizationResource = typeof(VenueManagementResource);
    }
}
