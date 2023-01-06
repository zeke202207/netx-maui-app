
namespace netxapp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
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