using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher;

public partial class ControlPage : BaseContentPage
{
	public ControlPage()
		:base(new ControlViewModel())
	{
		InitializeComponent();
	}
}