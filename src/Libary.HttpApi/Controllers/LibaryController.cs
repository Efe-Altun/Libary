using Libary.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Libary.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LibaryController : AbpControllerBase
{
    protected LibaryController()
    {
        LocalizationResource = typeof(LibaryResource);
    }
}
