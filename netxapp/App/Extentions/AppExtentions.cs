using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp;

public static class AppExtentions
{
    public static IServiceCollection AddPageViewModelService<TPage,TViewModel>(
        this IServiceCollection services)
    {
        services
            .AddTransient(typeof(TPage))
            .AddTransient(typeof(TViewModel));
        //Routing.RegisterRoute(routerName, typeof(TPage));
        return services;
    }
}
