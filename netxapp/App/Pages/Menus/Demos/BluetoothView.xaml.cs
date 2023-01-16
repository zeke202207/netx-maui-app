using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class BluetoothView : BaseContentView
{
	public BluetoothView()
		: base()
	{
		InitializeComponent();
        base.BindingContext<BluetoothViewModel>();
    }
}