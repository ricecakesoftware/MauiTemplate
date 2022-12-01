using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class MainShell
{
    public MainShell(MainShellViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
