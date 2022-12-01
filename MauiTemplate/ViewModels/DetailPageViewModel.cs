using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class DetailPageViewModel : AuthorizedViewModel
{
    public DetailPageViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
        HeaderTitle = "詳細";
    }

    [RelayCommand]
    private void Back()
    {
        NavigationService.GoToListPage();
    }
}
