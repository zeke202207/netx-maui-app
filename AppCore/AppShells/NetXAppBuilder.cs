using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
#if WINDOWS
using Microsoft.UI.Windowing;
using Microsoft.UI;
using Windows.Graphics;
#endif
using Microsoft.Maui.LifecycleEvents;
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
            //CustomerTitleBar(MauiAppBuilder);
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

        private void CustomerTitleBar(MauiAppBuilder builder)
        {
#if WINDOWS
            builder.ConfigureLifecycleEvents(lifecycle =>
            {
                lifecycle.AddWindows(windows =>
                {
                    windows.OnWindowCreated(window =>
                    {
                        window.ExtendsContentIntoTitleBar = false;
                        window.SetTitleBar(null);

                        ////window.ExtendsContentIntoTitleBar = true;
                        ////window.SetTitleBar(new CustomTitleBar());

                        //IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                        //WindowId win32WindowsId = Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                        //AppWindow winuiAppWindow = AppWindow.GetFromWindowId(win32WindowsId);

                        //var titleBar = winuiAppWindow.TitleBar;
                        //titleBar.BackgroundColor = new Windows.UI.Color() { A = 255, R = 255, G = 0, B = 0 };
                        //titleBar.ButtonBackgroundColor = new Windows.UI.Color() { A = 125, R = 255, G = 0, B = 0 };
                        //titleBar.InactiveBackgroundColor = new Windows.UI.Color() { A = 125, R = 255, G = 0, B = 0 };
                        //titleBar.ButtonInactiveBackgroundColor = new Windows.UI.Color() { A = 125, R = 255, G = 0, B = 0 };

                        //if (winuiAppWindow.Presenter is OverlappedPresenter p)
                        //{
                        //    //初始最小化
                        //    //p.Minimize();
                        //    //p.IsResizable = false;
                        //    //p.IsMaximizable = false;
                        //    //p.IsMinimizable = false;

                        //    //p.SetBorderAndTitleBar(true, false);
                        //}
                    });
                });
            });
#endif
        }
    }
}
