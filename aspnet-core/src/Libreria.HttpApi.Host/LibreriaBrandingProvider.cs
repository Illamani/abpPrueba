using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Libreria;

[Dependency(ReplaceServices = true)]
public class LibreriaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Libreria";
}
