using Avalonia.Web.Blazor;

namespace AvaloniaCrossPlatformApplication1.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<AvaloniaCrossPlatformApplication1.App>()
            .SetupWithSingleViewLifetime();
    }
}