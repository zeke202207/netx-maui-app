using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp;

public static class AppExtentions
{
    public static IServiceCollection AddContentPageViewModelService<TPage,TViewModel>(
        this IServiceCollection services)
        where TPage : Page
    {
        services
            .AddTransient(typeof(TPage))
            .AddTransient(typeof(TViewModel));
        //Routing.RegisterRoute(routerName, typeof(TPage));
        return services;
    }

    public static IServiceCollection AddContentViewViewModelService<TView, TViewModel>(
       this IServiceCollection services)
        where TView : View
    {
        services
            .AddTransient(typeof(TView))
            .AddTransient(typeof(TViewModel));
        //Routing.RegisterRoute(routerName, typeof(TPage));
        return services;
    }
}
