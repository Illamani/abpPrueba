using Libreria.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Libreria;

[DependsOn(
    typeof(LibreriaEntityFrameworkCoreTestModule)
    )]
public class LibreriaDomainTestModule : AbpModule
{

}
