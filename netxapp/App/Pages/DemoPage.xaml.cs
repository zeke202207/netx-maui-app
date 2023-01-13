using netxapp.Pages.ChildPage;
using netxapp.Services;
using netxapp.ViewModels;
using System.ComponentModel.Design;

namespace netxapp.Pages;

public partial class DemoPage : ContentPage
{
    private readonly IRoutingService _router;

    public DemoPage(IRoutingService router)
	{
        _router = router;
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //BluetoothPage bluetoothPage = new BluetoothPage();
        //Application.Current.MainPage.Navigation.PushModalAsync(bluetoothPage, true);

        //var navigationPage = new NavigationPage(new BluetoothPage());

        //await Shell.Current.GoToAsync("//bluetooth");

        //await Navigation.PushAsync(new BluetoothPage());

        await _router.NavigateTo("//bluetooth");
    }
}