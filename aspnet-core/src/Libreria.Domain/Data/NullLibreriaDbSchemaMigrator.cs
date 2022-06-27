using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Libreria.Data;

/* This is used if database provider does't define
 * ILibreriaDbSchemaMigrator implementation.
 */
public class NullLibreriaDbSchemaMigrator : ILibreriaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
