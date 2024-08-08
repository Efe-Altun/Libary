using Volo.Abp.Modularity;

namespace Libary;

/* Inherit from this class for your domain layer tests. */
public abstract class LibaryDomainTestBase<TStartupModule> : LibaryTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
