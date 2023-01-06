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

		builder.Services.AddScoped<LoginViewModel>();
		builder.Services.AddScoped<LoadingViewModel>();

		builder.Services.AddScoped<IRoutingService, ShellRoutingService>();
		builder.Services.AddScoped<IIdentityService, IdentityService>();

		return builder.Build();
	}
}
