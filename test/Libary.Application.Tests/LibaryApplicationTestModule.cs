using Volo.Abp.Modularity;

namespace Libary;

[DependsOn(
    typeof(LibaryApplicationModule),
    typeof(LibaryDomainTestModule)
)]
public class LibaryApplicationTestModule : AbpModule
{

}
