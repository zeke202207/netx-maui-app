
using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class HomePage : BaseContentPage
{
    public HomePage(HomeViewModel viewModel)
		:base(viewModel)
	{
		InitializeComponent();
		NavigatedTo += async (sender, e) =>
		{
			//if(null != _page)
			//{
			//	await DisplayAlert("info", "please click ok or cannel","ok");
			//	_page = null;
			//}
		};
		NavigatedFrom += async (sender, e) =>
		{
			//if (null != _page)
			//	_page = null;
		};
	}
}