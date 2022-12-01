namespace RiceCakeSoftware.MauiTemplate.Views;

public static class ViewsExtensions
{
    public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<UnauthorizedShell>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<MainShell>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<ListPage>();
        builder.Services.AddTransient<DetailPage>();
        return builder;
    }
}
