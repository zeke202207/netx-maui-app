using NetX.AppCore;
using NetX.AppLauncher.Pages;

namespace NetX.AppLauncher
{
    public partial class App : Application
    {
        private readonly MainPage _mainPage;

        public App(MainPage mainPage)
        {
            InitializeComponent();
            _mainPage = mainPage;

            //MainPage = ShellFactory.CreateCustomShell(() => new AppShell());
            MainPage = ShellFactory.CreateDefaultShell(ShellType.NetXShell, p =>
            {
                p.HeaderInfo = new AppCore.Model.HeaderInfo("netx maui", "logo.png");
                p.FooterInfo = new AppCore.Model.FooterInfo("© zeke 2023");
                p.Menu = new AppCore.Model.NetXShellMenu()
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
                };

                p.Contents = new List<AppCore.Model.NetXShellContent>()
                {
                    new AppCore.Model.NetXShellContent()
                    {
                         Title = "Login",
                         Route ="zeke",
                         Icon = "tab_home.png",
                         ContentTemplate = new DataTemplate(()=> _mainPage),
                         Order = 0,
                         FlyoutItemIsVisible = false
                    }
                };
            });
        }
    }
}