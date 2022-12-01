using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class ListPageViewModel : AuthorizedViewModel
{
    public ListPageViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
        HeaderTitle = "一覧";
    }

    [RelayCommand]
    private void Add()
    {
        NavigationService.GoToDetailPage();
    }
}
