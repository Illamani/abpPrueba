using Libreria.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Libreria.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LibreriaController : AbpControllerBase
{
    protected LibreriaController()
    {
        LocalizationResource = typeof(LibreriaResource);
    }
}
