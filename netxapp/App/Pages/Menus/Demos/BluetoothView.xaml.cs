using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class BluetoothView : BaseContentView
{
	public BluetoothView()
		: base()
	{
		InitializeComponent();
        base.BindingContext<BluetoothViewModel>();
		base.GetViewModel<BluetoothViewModel>().ScanResult+= async (int count) =>
        {
            Page page = Application.Current?.MainPage ?? throw new NullReferenceException();
            await page.DisplayAlert("info", count.ToString(), "ok", "cancel");
        };
    }
}