using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class DashboardPage
{
    public DashboardPage(DashboardPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
