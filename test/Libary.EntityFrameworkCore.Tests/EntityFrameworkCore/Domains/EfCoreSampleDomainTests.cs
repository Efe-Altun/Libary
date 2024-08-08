using Libary.Samples;
using Xunit;

namespace Libary.EntityFrameworkCore.Domains;

[Collection(LibaryTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LibaryEntityFrameworkCoreTestModule>
{

}
