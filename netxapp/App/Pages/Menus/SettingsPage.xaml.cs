using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class SettingsPage : BaseContentPage
{
	public SettingsPage(SettingViewModel viewModel)
        :base(viewModel)
	{
		InitializeComponent();
    }

    private async void btnOpenNewPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//login");
    }
}