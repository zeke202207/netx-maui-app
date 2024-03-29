﻿using NetX.AppCore;
using NetX.AppCore.Routings;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher
{
    public partial class MainPage : BaseContentPage
    {
        private readonly IRoutingService _routing;

        public MainPage(IRoutingService routing)
            :base(new MainViewModel())
        {
            InitializeComponent();
            _routing = routing;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //SemanticScreenReader.Announce(CounterBtn.Text);

            _routing.NavigateTo("//zeketab/zeke-tab-0");


            _ = NetXApp.Shell switch
            {
                NetXAppShell s => s.SetShellItem(item =>
                {
                    if (item.Title == "Login")
                    {
                        //item.IsEnabled = false;
                        item.FlyoutItemIsVisible = false;
                        //item.IsVisible = true;
                        //item.SetValue(Shell.FlyoutItemIsVisibleProperty, true);
                        item.Title = "Homexxx";
                    }
                }),
                _ => NetXApp.Shell
            };

            _ = NetXApp.Shell switch
            {
                NetXAppShell s => s.SetFlyoutBehavior(),
                _ => NetXApp.Shell
            };
        }
    }
}