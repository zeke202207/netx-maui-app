using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher.Controls;

public partial class UCButtonView : BaseContentView
{
	public UCButtonView()
		:base(new ButtonViewModel())
	{
		InitializeComponent();
	}
}