using Microsoft.Extensions.DependencyInjection;
using netxapp.Pages;
using netxapp.Services;
using netxapp.ViewModels;

namespace netxapp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
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
        services.AddPageViewModelService<WelcomePage, WelcomeViewModel>();
        services.AddPageViewModelService<LoginPage, LoginViewModel>();

        services.AddPageViewModelService<HomePage, HomeViewModel>();
        services.AddPageViewModelService<SettingsPage, SettingViewModel>();

        services.AddPageViewModelService<DemoPage, DemoViewModel>();
        services.AddPageViewModelService<BluetoothPage, BluetoothViewModel>();
        services.AddPageViewModelService<WifiPage, WifiViewModel>();

        return services;
    }

	public static IServiceCollection AddNetxService(this IServiceCollection services)
    {
        services.AddScoped<IRoutingService, ShellRoutingService>();
        services.AddScoped<IIdentityService, IdentityService>();
        return services;
    }
}
