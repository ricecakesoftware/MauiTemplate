using RiceCakeSoftware.MauiTemplate.ViewModels;

namespace RiceCakeSoftware.MauiTemplate.Views;

public partial class DetailPage
{
    public DetailPage(DetailPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
