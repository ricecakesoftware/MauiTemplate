namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public static class ViewModelsExtensions
{
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<UnauthorizedShellViewModel>();
        builder.Services.AddTransient<LoginPageViewModel>();
        builder.Services.AddTransient<MainShellViewModel>();
        builder.Services.AddTransient<DashboardPageViewModel>();
        builder.Services.AddTransient<ListPageViewModel>();
        builder.Services.AddTransient<DetailPageViewModel>();
        return builder;
    }
}
