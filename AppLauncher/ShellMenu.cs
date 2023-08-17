using NetX.AppCore.Model;
using NetX.AppLauncher.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppLauncher
{
    internal class ShellMenu
    {
        //YOU CAN GET DATA FROM DATABASE OR CONFIG FILE
        public static ShellConfig GetShellConfig()
        {
            return new ShellConfig()
            {
                HeaderInfo = new AppCore.Model.HeaderInfo("netx maui", "logo.png"),
                FooterInfo = new AppCore.Model.FooterInfo("© zeke 2023"),
                Menu = new AppCore.Model.NetXShellMenu()
                {
                    Order = 1,
                    Route = "zeketab",
                    Menus = new List<AppCore.Model.NetXShellMenuItem>()
                     {
                          new AppCore.Model.NetXShellMenuItem()
                          {
                               Order = 0,
                               Route = "zeke-tab-0",
                               Title = "Home",
                               Icon = "tab_home.png",
                               ContentTemplate = new DataTemplate(()=>new NewPage1()),
                               SearchHandler = new TestSearchHandler(){ Placeholder="zeke" }
                          },
                          new AppCore.Model.NetXShellMenuItem()
                          {
                               Order = 1,
                               Route = "zeke-tab-1",
                               Title = "SystemSetting",
                               Icon = "tab_home.png",
                               ContentTemplate = new DataTemplate(()=>new NewPage2())
                               //ContentTemplate = new DataTemplate(()=>new NewContent1())
                          },
                     }
                },

                Contents = new List<AppCore.Model.NetXShellContent>()
                {
                    new AppCore.Model.NetXShellContent()
                    {
                         Title = "Login",
                         Route ="zeke",
                         Icon = "tab_home.png",
                         ContentTemplate = new DataTemplate(()=> IPlatformApplication.Current.Services.GetService<MainPage>()),
                         Order = 0,
                         FlyoutItemIsVisible = false
                    }
                },
            };
        }

    }
}
