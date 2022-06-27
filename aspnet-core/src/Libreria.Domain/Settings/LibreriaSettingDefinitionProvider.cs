using Volo.Abp.Settings;

namespace Libreria.Settings;

public class LibreriaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LibreriaSettings.MySetting1));
    }
}
