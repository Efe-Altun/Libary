using Libary.Books;
using Xunit;

namespace Libary.EntityFrameworkCore.Applications.Books;

[Collection(LibaryTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<LibaryEntityFrameworkCoreTestModule>
{

}