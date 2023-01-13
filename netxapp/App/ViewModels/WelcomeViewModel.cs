using netxapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        private readonly IRoutingService routingService;
        private readonly IIdentityService identityService;

        public WelcomeViewModel(IRoutingService routingService = null, IIdentityService identityService = null)
        {
            this.routingService = routingService ?? IPlatformApplication.Current.Services.GetService<IRoutingService>();
            this.identityService = identityService ?? IPlatformApplication.Current.Services.GetService<IIdentityService>();
            base.Title = "zeke test...";
        }

        /// <summary>
        /// 
        /// </summary>
        public async void Init()
        {
            var isAuthenticated = await this.identityService.VerifyRegistration();
            if (isAuthenticated)
                await this.routingService.NavigateTo("///login");
            else
                await this.routingService.NavigateTo("///login");
        }
    }
}
