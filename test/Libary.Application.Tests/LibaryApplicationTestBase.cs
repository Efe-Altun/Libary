using Volo.Abp.Modularity;

namespace Libary;

public abstract class LibaryApplicationTestBase<TStartupModule> : LibaryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
