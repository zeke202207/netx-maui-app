namespace netxapp.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
    }

    private async void btnOpenNewPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//login");
    }
}