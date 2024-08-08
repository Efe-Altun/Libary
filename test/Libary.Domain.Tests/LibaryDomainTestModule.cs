using Volo.Abp.Modularity;

namespace Libary;

[DependsOn(
    typeof(LibaryDomainModule),
    typeof(LibaryTestBaseModule)
)]
public class LibaryDomainTestModule : AbpModule
{

}
