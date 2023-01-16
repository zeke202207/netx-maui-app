using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Services
{
    public class ShellRoutingService : IRoutingService
    {
        public ShellRoutingService()
        {
        }

        public async Task NavigateTo(string route)
        {
            await Shell.Current.GoToAsync(route);
        }

        public async Task NavigationPopAsync()
        {
            await Shell.Current.Navigation.PopAsync();
        }

        public async Task NavigationPopAsync(bool animated)
        {
            await Shell.Current.Navigation.PopAsync(animated);
        }

        public async Task NavigationPopModalAsync()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }

        public async Task NavigationPopModalAsync(bool animated)
        {
            await Shell.Current.Navigation.PopModalAsync(animated);
        }

        public async Task NavigationPushAsync(Page page)
        {
            await Shell.Current.Navigation.PushAsync(page);
        }

        public async Task NavigationPushAsync(Page page, bool animated)
        {
            await Shell.Current.Navigation.PushAsync(page,animated);
        }

        public async Task NavigationPushModalAsync(Page page)
        {
            await Shell.Current.Navigation.PushModalAsync(page);
        }

        public async Task NavigationPushModalAsync(Page page, bool animated)
        {
            await Shell.Current.Navigation.PushModalAsync(page, animated);
        }
    }
}
