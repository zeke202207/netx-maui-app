using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher.Controls;

public partial class UCRefreshView : BaseContentView
{
	public UCRefreshView()
		:base(new RefreshViewViewModel())
	{
		InitializeComponent();
	}
}