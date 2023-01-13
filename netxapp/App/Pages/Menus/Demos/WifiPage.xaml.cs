using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class WifiPage : BaseContentPage
{
	public WifiPage(WifiViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}
}