using RiceCakeSoftware.MauiTemplate.Views;

namespace RiceCakeSoftware.MauiTemplate;

public partial class App
{
    public App(UnauthorizedShell shell)
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        MainPage = shell;
    }
}
