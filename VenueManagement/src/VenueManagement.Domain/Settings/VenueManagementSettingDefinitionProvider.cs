using Volo.Abp.Settings;

namespace VenueManagement.Settings;

public class VenueManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(VenueManagementSettings.MySetting1));
    }
}
