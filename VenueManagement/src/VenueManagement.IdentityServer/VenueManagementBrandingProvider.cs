using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VenueManagement;

[Dependency(ReplaceServices = true)]
public class VenueManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VenueManagement";
}
