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
		builder.Services.AddPageView();
        builder.Services.AddCoreService();
        return builder.Build();
	}

    /// <summary>
    /// page & view dependency injection
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
	public static IServiceCollection AddPageView(this IServiceCollection services)
    {
        services.AddPage<WelcomePage, WelcomeViewModel>()
            .AddPage<LoginPage, LoginViewModel>()
            .AddPage<HomePage, HomeViewModel>()
            .AddPage<SettingsPage, SettingViewModel>()
            .AddPage<DemoPage, DemoViewModel>()
            .AddPage<DetailNavigatePage, DetailNavigateViewModel>();
        services.AddView<BluetoothView, BluetoothViewModel>()
            .AddView<WifiView, WifiViewModel>()
            .AddView<ApiRequestView, ApiRequestViewModel>()
            .AddView<AllControlsView, AllControlsViewModel>();
        return services;
    }

    /// <summary>
    /// core service dependency injection
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
	public static IServiceCollection AddCoreService(this IServiceCollection services)
    {
        services.AddScoped<IRoutingService, ShellRoutingService>();
        services.AddScoped<IIdentityService, IdentityService>();
        return services;
    }
}
