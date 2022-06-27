using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Libreria.Data;
using Volo.Abp.DependencyInjection;

namespace Libreria.EntityFrameworkCore;

public class EntityFrameworkCoreLibreriaDbSchemaMigrator
    : ILibreriaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLibreriaDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LibreriaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LibreriaDbContext>()
            .Database
            .MigrateAsync();
    }
}
