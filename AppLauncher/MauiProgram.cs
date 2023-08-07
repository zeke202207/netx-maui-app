using Microsoft.Extensions.Logging;
using NetX.AppCore.Extentions;
using NetX.AppCore.Routings;

namespace NetX.AppLauncher
{
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.Temp();

            return builder.Build();
        }

        private static IServiceCollection Temp(this IServiceCollection services)
        {
            services.AddPageViewBindingContext<MainPage,string>(ServiceLifetime.Scoped);
            services.AddSingleton<IRoutingService, ShellRoutingService>();
            return services;
        }
    }
}