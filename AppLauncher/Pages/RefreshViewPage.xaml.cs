using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher.Pages;

public partial class RefreshViewPage : BaseContentPage
{
	public RefreshViewPage()
		:base(new RefreshViewViewModel())
	{
		InitializeComponent();
	}
}