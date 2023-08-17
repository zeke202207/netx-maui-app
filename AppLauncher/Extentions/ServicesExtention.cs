using NetX.AppCore.Extentions;
using NetX.AppCore.Routings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppLauncher
{
    public static class ServicesExtention
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddPageViewBindingContext<MainPage, string>(ServiceLifetime.Scoped);
            services.AddSingleton<IRoutingService, ShellRoutingService>();
            return services;
        }
    }
}
