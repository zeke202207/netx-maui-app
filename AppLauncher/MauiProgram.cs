﻿using Microsoft.Extensions.Logging;
using NetX.AppCore;
using NetX.AppCore.AppShells;

namespace NetX.AppLauncher
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = NetXAppBuilder.Instance.CreateBuilder();
            return builder
                .UseApp<NetXApplication>(
                () => ShellFactory.CreateDefaultShell(() => ShellMenu.GetShellConfig()).InitTheme(Theme.Dark),
                 new ResourceDictionary[2] { new Resources.Styles.Colors(), new Resources.Styles.Styles() })
                .ConfigureFonts(() => "OpenSans-Semibold.ttf")
                .AddLog(logbuilder =>
                {
#if DEBUG
                    logbuilder.AddDebug();
#endif
                })
                .AddServices(s => s.AddCoreServices())
                .Build();
        }
    }
}