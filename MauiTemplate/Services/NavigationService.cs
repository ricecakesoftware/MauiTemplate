using RiceCakeSoftware.MauiTemplate.Views;

namespace RiceCakeSoftware.MauiTemplate.Services;

public class NavigationService : INavigationService
{
    public void GoToLoginPage() => Shell.Current.GoToAsync($"//{nameof(LoginPage)}");

    public void GoToMainPage() => Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");

    public void GoToDetailPage() => Shell.Current.GoToAsync($"//{nameof(DetailPage)}");

    public void GoToListPage() => Shell.Current.GoToAsync($"//{nameof(ListPage)}");
}
