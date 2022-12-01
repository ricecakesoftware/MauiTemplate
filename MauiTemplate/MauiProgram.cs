using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using RiceCakeSoftware.MauiTemplate.Services;
using RiceCakeSoftware.MauiTemplate.ViewModels;
using RiceCakeSoftware.MauiTemplate.Views;

namespace RiceCakeSoftware.MauiTemplate;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.UseMauiCommunityToolkit();
        builder.ConfigureServices();
        builder.ConfigureViewModels();
        builder.ConfigureViews();
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
