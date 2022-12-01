using CommunityToolkit.Mvvm.Input;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class AuthorizedViewModel : ViewModelBase
{
    public AuthorizedViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
    }

    [RelayCommand]
    public void Logout()
    {
        NavigationService.GoToLoginPage();
    }
}
