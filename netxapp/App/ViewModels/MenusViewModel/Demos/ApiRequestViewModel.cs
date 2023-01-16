using netxapp.Pages;
using netxapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace netxapp.ViewModels.MenusViewModel.Demos
{
    public class ApiRequestViewModel : BaseViewModel
    {
        private readonly IRoutingService _routingService;
        private readonly DetailNavigatePage _page;

        public string UserName { get; set; }

        public ICommand ExecuteTest { get; set; }

        public ApiRequestViewModel(IRoutingService routing ,DetailNavigatePage page)
        {
            _routingService = routing;
            _page = page;
            UserName = User.ID.ToString();
            ExecuteTest = new Command(async () => await Test());
        }

        private async Task Test()
        {
            base.IsBusy = true;
            var result = await base.Session.UserActor.Identificate(new Models.LoginModel { UserName = UserName, Password = "123456" });
            base.IsBusy = false;
            await _routingService.NavigationPushAsync(_page);
        }
    }
}
