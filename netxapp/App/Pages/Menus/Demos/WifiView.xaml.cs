using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class WifiView : BaseContentView
{
	public WifiView()
		: base()
	{
		InitializeComponent();
        base.BindingContext<WifiViewModel>();
    }
}