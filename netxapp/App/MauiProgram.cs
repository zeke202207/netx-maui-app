using Microsoft.Extensions.DependencyInjection;
using netxapp.Pages;
using netxapp.Pages.ChildPage;
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
		builder.Services.AddViewModelService();
        builder.Services.AddNetxService();
        builder.Services.AddPageService();
        return builder.Build();
	}

	public static IServiceCollection AddViewModelService(this IServiceCollection services)
	{
        services.AddScoped<LoginViewModel>();
        services.AddScoped<LoadingViewModel>();
        return services;
    }

	public static IServiceCollection AddNetxService(this IServiceCollection services)
    {
        services.AddScoped<IRoutingService, ShellRoutingService>();
        services.AddScoped<IIdentityService, IdentityService>();
        return services;
    }

    public static IServiceCollection AddPageService(this IServiceCollection services)
    {
        services.AddScoped<BluetoothPage>();
        services.AddScoped<DemoPage>();
        return services;
    }
}
