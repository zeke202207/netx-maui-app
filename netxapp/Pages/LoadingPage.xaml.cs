using Microsoft.Maui.Hosting;
using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}

    internal LoadingViewModel ViewModel { get; set; } = IPlatformApplication.Current.Services.GetRequiredService<LoadingViewModel>();

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.Init();
    }
}