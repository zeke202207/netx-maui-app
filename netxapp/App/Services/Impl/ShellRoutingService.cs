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

        public async Task GoBack()
        {
            await Shell.Current.Navigation.PopAsync();
        }

        public async Task GoBackModal()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}
