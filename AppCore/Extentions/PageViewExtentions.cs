using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Extentions;

public static class PageViewExtentions
{
    /// <summary>
    /// 页面与视图依赖注入
    /// TViewModel自动绑定到 BindingContext 中
    /// </summary>
    /// <typeparam name="TPageView">页面、视图</typeparam>
    /// <typeparam name="TViewModel">BindingContext实体对象</typeparam>
    /// <param name="services">注入服务集合</param>
    /// <returns></returns>
    public static IServiceCollection AddPageViewBindingContext<TPageView, TViewModel>(
        this IServiceCollection services,
        ServiceLifetime serviceLifetime)
    {
        return serviceLifetime switch
        {
            ServiceLifetime.Scoped => services
                                       .AddScoped(typeof(TViewModel))
                                       .AddScoped(typeof(TPageView)),
            ServiceLifetime.Singleton => services
                                        .AddSingleton(typeof(TViewModel))
                                        .AddSingleton(typeof(TPageView)),
            ServiceLifetime.Transient => services
                                       .AddTransient(typeof(TViewModel))
                                       .AddTransient(typeof(TPageView)),
            _ => throw new NotSupportedException("不支持的注入生命周期")
        };
    }
}
