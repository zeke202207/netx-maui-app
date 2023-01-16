using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using netxapp.Pages;
using netxapp.Services;
using netxapp.ViewModels;
using netxapp.ViewModels.MenusViewModel.Demos;
using Sharpnado.Tabs;

namespace netxapp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseSharpnadoTabs(false)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddNetxPageViewModelService();
        builder.Services.AddNetxService();
        return builder.Build();
	}

	public static IServiceCollection AddNetxPageViewModelService(this IServiceCollection services)
    {
        services.AddContentPageViewModelService<WelcomePage, WelcomeViewModel>();
        services.AddContentPageViewModelService<LoginPage, LoginViewModel>();

        services.AddContentPageViewModelService<HomePage, HomeViewModel>();
        services.AddContentPageViewModelService<SettingsPage, SettingViewModel>();

        services.AddContentPageViewModelService<DemoPage, DemoViewModel>();
        services.AddContentViewViewModelService<BluetoothView, BluetoothViewModel>();
        services.AddContentViewViewModelService<WifiView, WifiViewModel>();        
        services.AddContentViewViewModelService<ApiRequestView, ApiRequestViewModel>();
        services.AddContentViewViewModelService<AllControlsView, AllControlsViewModel>();
        services.AddContentPageViewModelService<DetailNavigatePage, DetailNavigateViewModel>();

        return services;
    }

	public static IServiceCollection AddNetxService(this IServiceCollection services)
    {
        services.AddScoped<IRoutingService, ShellRoutingService>();
        services.AddScoped<IIdentityService, IdentityService>();
        return services;
    }
}
