using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RiceCakeSoftware.MauiTemplate.Services;

namespace RiceCakeSoftware.MauiTemplate.ViewModels;

[ObservableObject]
public partial class ViewModelBase
{
    protected IAlertService AlertService { get; private set; }
    protected INavigationService NavigationService { get; private set; }

    [ObservableProperty]
    private string _headerTitle = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool _isBusy;

    public bool IsNotBusy => !_isBusy;

    public ViewModelBase(IAlertService alertService, INavigationService navigationService)
    {
        AlertService = alertService;
        NavigationService = navigationService;
    }
}
