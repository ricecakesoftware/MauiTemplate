using CommunityToolkit.Mvvm.ComponentModel;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class DashboardPageViewModel : AuthorizedViewModel
{
    public DashboardPageViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
        HeaderTitle = "ダッシュボード";
    }
}
