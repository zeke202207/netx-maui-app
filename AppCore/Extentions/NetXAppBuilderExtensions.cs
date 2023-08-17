using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using NetX.AppCore.AppShells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public static class NetXAppBuilderExtensions
    {
        public static NetXAppBuilder UseApp<TApp>(
            this NetXAppBuilder builder, 
            Func<Shell> createShell,
            ResourceDictionary[] resources)
            where TApp : NetXApplication
        {
            builder.MauiAppBuilder.UseMauiApp<TApp>(provider =>
            {
                NetXApplication.Instance.CreateShell(createShell)
                .AddResources(resources);
                return (TApp)NetXApplication.Instance;
            });
            return builder;
        }

        public static NetXAppBuilder ConfigureFonts(this NetXAppBuilder builder, Action<IFontCollection>? configureDelegate)
        {
            if(null == configureDelegate)
                return builder;
            builder.MauiAppBuilder.ConfigureFonts(configureDelegate);
            return builder;
        }

        public static NetXAppBuilder AddLog(this NetXAppBuilder builder, Action<ILoggingBuilder> loggerBuilderDelegate)
        {
            if(null ==  loggerBuilderDelegate)
                return builder;
            loggerBuilderDelegate.Invoke(builder.Logging);
            return builder;
        }

        public static NetXAppBuilder AddServices(this NetXAppBuilder builder, Action<IServiceCollection> servicesDelegate)
        {
            if (null == servicesDelegate)
                return builder;
            servicesDelegate.Invoke(builder.Services);
            return builder;
        }
    }
}
