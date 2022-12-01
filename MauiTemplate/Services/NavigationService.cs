using RiceCakeSoftware.MauiTemplate.Views;

namespace RiceCakeSoftware.MauiTemplate.Services;

public class NavigationService : INavigationService
{
    private readonly IServiceProvider _provider;

    public NavigationService(IServiceProvider provider) => _provider = provider;

    public void GoToLoginPage() => NavigateToPage<UnauthorizedShell>();

    public void GoToMainPage() => NavigateToPage<MainShell>();

    public void GoToDetailPage() => Shell.Current.GoToAsync(nameof(DetailPage));

    public void GoToListPage() => Shell.Current.Navigation.PopAsync();

    private void NavigateToPage<T>() where T : Page
    {
        Page? page = ResolvePage<T>();
        if (page != null && Application.Current != null)
        {
            Application.Current.MainPage = page;
        }
        else
        {
            throw new Exception();
        }
    }

    private T? ResolvePage<T>() where T : Page => _provider.GetService<T>();
}
