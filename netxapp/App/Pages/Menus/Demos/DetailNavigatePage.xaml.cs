using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class DetailNavigatePage : BaseContentPage
{
	public DetailNavigatePage(DetailNavigateViewModel viewModel)
		:base(viewModel)
	{
		InitializeComponent();
	}
}