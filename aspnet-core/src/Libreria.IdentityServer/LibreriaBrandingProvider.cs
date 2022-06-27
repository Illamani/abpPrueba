using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Libreria;

[Dependency(ReplaceServices = true)]
public class LibreriaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Libreria";
}
