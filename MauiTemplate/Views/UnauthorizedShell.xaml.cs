using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class UnauthorizedShell
{
    public UnauthorizedShell(UnauthorizedShellViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
