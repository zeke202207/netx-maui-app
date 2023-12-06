using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform;
using NetX.AppCore.Model;
using NetX.AppCore.Pages.Template;

namespace NetX.AppCore;

public partial class NetXAppShell : Shell
{
    private readonly Guid _id;

    public NetXAppShell(ShellConfig config)
    {
        InitializeComponent();
        this.BindingContext = config;
        InitShell();
        _id = Guid.NewGuid();
    }

    /// <summary>
    /// 设置FlyoutBehavior
    /// 主要用于桌面程序
    /// 一般情况，登录成功后设置
    /// <example>
    ///  _ = NetXApp.Shell switch
    ///         {
    ///             NetXAppShell s => s.SetFlyoutBehavior(),
    ///             _ => NetXApp.Shell
    ///         };
    /// </example>
    /// </summary>
    public NetXAppShell SetFlyoutBehavior()
    {
        if (NetXApp.Device.Idiom() == DeviceIdiom.Phone)
            netxshell.FlyoutBehavior = FlyoutBehavior.Disabled;
        else
            netxshell.FlyoutBehavior = FlyoutBehavior.Flyout;
        return this;
    }

    /// <summary>
    /// 设置item
    /// </summary>
    /// <param name="setItem"></param>
    /// <example>
    /// _ = NetXApp.Shell switch
    ///         {
    ///             NetXAppShell s => s.SetShellItem(item =>
    ///                 {
    ///                     if (item.Title == "Login")
    ///                     {
    ///                         //item.IsEnabled = false;
    ///                         //item.FlyoutItemIsVisible = false;
    ///                         item.IsVisible = true;
    ///                         //item.SetValue(Shell.FlyoutItemIsVisibleProperty, true);
    ///                         item.Title = "Homexxx";
    ///                     }
    ///                 }),
    ///                         _ => NetXApp.Shell
    ///         };
    /// </example>
    /// <remarks>
    /// 注意：有些属性修改后可能，对象修改成功，但是页面没有刷新
    /// 暂时没找到刷新方法，待补充
    /// </remarks>
    /// <returns></returns>
    public NetXAppShell SetShellItem(Action<ShellItem> setItem)
    {
        netxshell.Items.ToList().ForEach(item =>
        {
            setItem?.Invoke(item);
        });
        return this;
    }

    /// <summary>
    /// 初始化shell
    /// </summary>
    private void InitShell()
    {
        LoadCustomerResoures();
        var config = this.BindingContext as ShellConfig;
        InitShell(config);
        InitContent(config);
        if (NetXApp.Device.Idiom() == DeviceIdiom.Phone)
            InitPhoneTabBar(config);
        else
            InitDesktopFlyoutItem(config);
    }

    /// <summary>
    /// 加载自定义资源
    /// </summary>
    /// <example>
    /// TextColor="{StaticResource Zeke}"
    /// </example>
    private void LoadCustomerResoures()
    {
        Resources.MergedDictionaries.Add(new Resources.Styles.Button());
        Resources.MergedDictionaries.Add(new Resources.Styles.Label());
        Resources.MergedDictionaries.Add(new Resources.Styles.FlyoutPage());
        Application.Current.Resources.MergedDictionaries.Add(Resources);
        //Application.Current.Resources.
    }

    /// <summary>
    /// 配置shell
    /// </summary>
    /// <param name="config"></param>
    private void InitShell(ShellConfig config)
    {
        netxshell.FlyoutBehavior = FlyoutBehavior.Disabled;
        netxshell.FlyoutHeaderBehavior = FlyoutHeaderBehavior.CollapseOnScroll;
        netxshell.SetValue(TabBarIsVisibleProperty, NetXApp.Device.Idiom() == DeviceIdiom.Phone ? true : false);
        netxshell.SetValue(NavBarIsVisibleProperty, config.NavBarIsVisible);
        netxshell.SetValue(FlyoutWidthProperty, config.Menu.FlyoutWidth);
        //netxshell.SetValue(FlyoutBackgroundColorProperty,Colors.Red);

        netxshell.FlyoutHeaderTemplate = config.Header ?? new DataTemplate(() => new Header(config));
        netxshell.FlyoutFooterTemplate = config.Footer ?? new DataTemplate(() => new Footer(config));
    }

    /// <summary>
    /// 配置content
    /// </summary>
    /// <param name="config"></param>
    private void InitContent(ShellConfig config)
    {
        foreach (var item in config.Contents.OrderBy(p => p.Order))
        {
            netxshell.Items.Add(
               new ShellContent()
               {
                   ContentTemplate = item.ContentTemplate,
                   Title = item.Title,
                   Route = item.Route,
                   Icon = item.Icon,
                   FlyoutItemIsVisible = item.FlyoutItemIsVisible
               });
        }
    }

    /// <summary>
    /// 配置tabbar
    /// </summary>
    /// <param name="config"></param>
    private void InitPhoneTabBar(ShellConfig config)
    {
        if (null != config.Menu && config.Menu.Menus?.Count > 0)
        {
            var tabBar = new TabBar()
            {
                Route = config.Menu.Route,
                Title = config.Menu.Title,
                Icon = config.Menu.Icon,
                FlyoutItemIsVisible = config.Menu.FlyoutItemIsVisible,
            };
            netxshell.Items.Add(tabBar);
            foreach (var item in config.Menu.Menus)
            {
                var content = new ShellContent()
                {
                    ContentTemplate = item.ContentTemplate,
                    Title = item.Title,
                    Icon = item.Icon,
                    Route = item.Route,
                    FlyoutItemIsVisible = item.FlyoutItemIsVisible,
                };
                tabBar.Items.Add(content);
                if (null != item.SearchHandler)
                    InitSearchBar(content, item.SearchHandler);
            }
        }
    }

    /// <summary>
    /// 桌面布局
    /// </summary>
    private void InitDesktopFlyoutItem(ShellConfig config)
    {
        if (null != config.Menu && config.Menu.Menus?.Count > 0)
        {
            FlyoutItem flyoutItem = new FlyoutItem()
            {
                Title = config.Menu.Title,
                Icon = config.Menu.Icon,
                Route = $"{config.Menu.Route}",
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                FlyoutItemIsVisible = config.Menu.FlyoutItemIsVisible,
            };
            netxshell.Items.Add(flyoutItem);
            foreach (var item in config.Menu.Menus)
            {
                var content = new ShellContent()
                {
                    ContentTemplate = item.ContentTemplate,
                    Title = item.Title,
                    Icon = item.Icon,
                    Route = item.Route,
                    FlyoutItemIsVisible = item.FlyoutItemIsVisible,
                };
                flyoutItem.Items.Add(content);
                if (null != item.SearchHandler)
                    InitSearchBar(content, item.SearchHandler);
                Shell.SetFlyoutBehavior(content, config.Menu.MenuFlyout);
            }
        }
    }

    /// <summary>
    /// 初始化设置查询框
    /// </summary>
    /// <param name="item"></param>
    /// <param name="handler"></param>
    private void InitSearchBar(BindableObject item ,SearchHandler handler)
    {
        Shell.SetSearchHandler(item, handler);
    }
}