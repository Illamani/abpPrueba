using System.Threading.Tasks;

namespace Libreria.Data;

public interface ILibreriaDbSchemaMigrator
{
    Task MigrateAsync();
}
