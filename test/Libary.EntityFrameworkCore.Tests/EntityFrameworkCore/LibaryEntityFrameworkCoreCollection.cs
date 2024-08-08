using Xunit;

namespace Libary.EntityFrameworkCore;

[CollectionDefinition(LibaryTestConsts.CollectionDefinitionName)]
public class LibaryEntityFrameworkCoreCollection : ICollectionFixture<LibaryEntityFrameworkCoreFixture>
{

}
