using Libary.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Libary.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LibaryEntityFrameworkCoreModule),
    typeof(LibaryApplicationContractsModule)
)]
public class LibaryDbMigratorModule : AbpModule
{
}
