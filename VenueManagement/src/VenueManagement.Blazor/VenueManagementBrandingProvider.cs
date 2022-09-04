using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace VenueManagement.Blazor;

[Dependency(ReplaceServices = true)]
public class VenueManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VenueManagement";
}
