using System.Threading.Tasks;

namespace Libary.Data;

public interface ILibaryDbSchemaMigrator
{
    Task MigrateAsync();
}
