using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class AppShell
{
    public AppShell(AppShellViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
