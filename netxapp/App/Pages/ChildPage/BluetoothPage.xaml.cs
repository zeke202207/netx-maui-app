
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using netxapp.ViewModels;

namespace netxapp.Pages.ChildPage;

public partial class BluetoothPage : ContentPage
{
	public BluetoothPage()
	{
		InitializeComponent();
        this.BindingContext = new BluetoothDemoViewModel();
	}
}