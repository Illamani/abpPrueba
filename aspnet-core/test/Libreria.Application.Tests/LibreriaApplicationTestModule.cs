using Volo.Abp.Modularity;

namespace Libreria;

[DependsOn(
    typeof(LibreriaApplicationModule),
    typeof(LibreriaDomainTestModule)
    )]
public class LibreriaApplicationTestModule : AbpModule
{

}
