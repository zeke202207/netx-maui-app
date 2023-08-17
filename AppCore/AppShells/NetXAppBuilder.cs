using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.AppShells
{
    public sealed class NetXAppBuilder
    {
        private static Lazy<NetXAppBuilder> instance = new Lazy<NetXAppBuilder>(() => new NetXAppBuilder());

        private NetXAppBuilder(){ }

        public static NetXAppBuilder Instance { get { return instance.Value; } }

        public IServiceCollection Services { get; private set; }

        public ConfigurationManager Configuration { get; private set; }

        public ILoggingBuilder Logging { get; private set; }

        public MauiAppBuilder MauiAppBuilder { get; private set; }

        public NetXAppBuilder CreateBuilder()
        {
            MauiAppBuilder = MauiApp.CreateBuilder();
            return new NetXAppBuilder()
            {
                Services = MauiAppBuilder.Services,
                Configuration = MauiAppBuilder.Configuration,
                Logging = MauiAppBuilder.Logging,
                MauiAppBuilder = MauiAppBuilder
            };
        }

        public MauiApp Build()
        {
            return MauiAppBuilder.Build();
        }
    }
}
