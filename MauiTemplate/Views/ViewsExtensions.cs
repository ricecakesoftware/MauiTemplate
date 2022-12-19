namespace RiceCakeSoftware.MauiTemplate.Views;

public static class ViewsExtensions
{
    public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<ListPage>();
        builder.Services.AddTransient<DetailPage>();
        return builder;
    }
}
