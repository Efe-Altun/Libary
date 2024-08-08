using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Libary.Data;

/* This is used if database provider does't define
 * ILibaryDbSchemaMigrator implementation.
 */
public class NullLibaryDbSchemaMigrator : ILibaryDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
