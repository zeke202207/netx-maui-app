using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp;

public static class PageViewExtentions
{
    /// <summary>
    /// page dependency injection
    /// </summary>
    /// <typeparam name="TPage"></typeparam>
    /// <typeparam name="TViewModel"></typeparam>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddPage<TPage,TViewModel>(
        this IServiceCollection services)
        where TPage : Page
    {
        services
            .AddTransient(typeof(TPage))
            .AddTransient(typeof(TViewModel));
        //Routing.RegisterRoute(routerName, typeof(TPage));
        return services;
    }

    /// <summary>
    /// view dependency injection
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <typeparam name="TViewModel"></typeparam>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddView<TView, TViewModel>(
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
