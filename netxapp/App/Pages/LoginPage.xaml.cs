using netxapp.ViewModels;
using System.ComponentModel.Design;

namespace netxapp.Pages;

public partial class LoginPage : BaseContentPage
{
	public LoginPage(LoginViewModel viewModel)
		:base(viewModel)
	{
		InitializeComponent();
		viewModel.LoginFailed += async (string message) =>
		{
			await DisplayAlert("error", message, "ok");
		};
	}
}