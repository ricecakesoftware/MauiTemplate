using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

public partial class UnauthorizedViewModel : ViewModelBase
{
    public UnauthorizedViewModel(IAlertService alertService, INavigationService navigationService)
        : base(alertService, navigationService)
    {
    }
}
