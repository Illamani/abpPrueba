using System;
using System.Collections.Generic;
using System.Text;
using Libreria.Localization;
using Volo.Abp.Application.Services;

namespace Libreria;

/* Inherit your application services from this class.
 */
public abstract class LibreriaAppService : ApplicationService
{
    protected LibreriaAppService()
    {
        LocalizationResource = typeof(LibreriaResource);
    }
}
