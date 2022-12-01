using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class ListPage
{
    public ListPage(ListPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
