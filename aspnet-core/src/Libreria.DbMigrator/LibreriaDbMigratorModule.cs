using Libreria.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Libreria.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LibreriaEntityFrameworkCoreModule),
    typeof(LibreriaApplicationContractsModule)
    )]
public class LibreriaDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
