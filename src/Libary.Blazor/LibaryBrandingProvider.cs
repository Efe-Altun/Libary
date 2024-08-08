using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Libary.Blazor;

[Dependency(ReplaceServices = true)]
public class LibaryBrandingProvider : DefaultBrandingProvider
{
	public override string AppName => "";

}
