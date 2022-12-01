using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class LoginPageViewModel : UnauthorizedViewModel
{
    [ObservableProperty]
    private string _userId = string.Empty;
    [ObservableProperty]
    private string _password = string.Empty;

    public LoginPageViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
        HeaderTitle = "ログイン";
    }

    [RelayCommand]
    private void Login()
    {
        NavigationService.GoToMainPage();
    }
}
