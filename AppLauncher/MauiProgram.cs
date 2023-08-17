using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.StyleSheets;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.UI.Xaml.Markup;
using NetX.AppCore;
using NetX.AppCore.AppShells;
using NetX.AppCore.Extentions;
using NetX.AppCore.Routings;
using NetX.AppLauncher.Pages;
using System.Linq;

namespace NetX.AppLauncher
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = NetXAppBuilder.Instance.CreateBuilder();
            return builder
                .UseApp<NetXApplication>(
                ()=> ShellFactory.CreateDefaultShell(() => ShellMenu.GetShellConfig()),
                 new ResourceDictionary[2]{ new Resources.Styles.Colors(),new Resources.Styles.Styles() })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .AddLog(logbuilder =>
                {
#if DEBUG
                    logbuilder.AddDebug();
#endif
                })
                .AddServices(s=>s.AddCoreServices())
                .Build();
        }
    }
}