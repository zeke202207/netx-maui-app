using netxapp.ViewModels;
using System.ComponentModel.Design;

namespace netxapp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = ViewModel;
		ViewModel.LoginResult += async (bool success, string message) =>
		{
            if (success)
                await Shell.Current.GoToAsync("//main/home");
            else
                await DisplayAlert("error", message, "ok");
        };
	}

	internal LoginViewModel ViewModel { get; set; } = IPlatformApplication.Current.Services.GetRequiredService<LoginViewModel>();
}