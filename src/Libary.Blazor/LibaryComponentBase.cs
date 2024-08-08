using Libary.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Libary.Blazor;

public abstract class LibaryComponentBase : AbpComponentBase
{
    protected LibaryComponentBase()
    {
        LocalizationResource = typeof(LibaryResource);
    }
}
