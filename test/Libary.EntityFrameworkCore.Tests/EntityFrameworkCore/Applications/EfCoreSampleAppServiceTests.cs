using Libary.Samples;
using Xunit;

namespace Libary.EntityFrameworkCore.Applications;

[Collection(LibaryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LibaryEntityFrameworkCoreTestModule>
{

}
