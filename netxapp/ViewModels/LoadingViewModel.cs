using netxapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.ViewModels
{
    public class LoadingViewModel :BaseViewModel
    {
        private readonly IRoutingService routingService;
        private readonly IIdentityService identityService;

        public LoadingViewModel(IRoutingService routingService = null, IIdentityService identityService = null)
        {
            this.routingService = routingService ?? IPlatformApplication.Current.Services.GetService<IRoutingService>();
            this.identityService = identityService ?? IPlatformApplication.Current.Services.GetService<IIdentityService>();
        }

        /// <summary>
        /// 
        /// </summary>
        public async void Init()
        {
            var isAuthenticated = await this.identityService.VerifyRegistration();
            if (isAuthenticated)
                await this.routingService.NavigateTo("///main");
            else
                await this.routingService.NavigateTo("///login");
        }
    }
}
