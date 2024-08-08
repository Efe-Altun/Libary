using Libary.Localization;
using Volo.Abp.Application.Services;

namespace Libary;

/* Inherit your application services from this class.
 */
public abstract class LibaryAppService : ApplicationService
{
    protected LibaryAppService()
    {
        LocalizationResource = typeof(LibaryResource);
    }


}
