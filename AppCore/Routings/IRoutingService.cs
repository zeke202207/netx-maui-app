using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Routings
{
    public interface IRoutingService
    {
        Task NavigateTo(string route);

        Task NavigationPushAsync(Page page);
        Task NavigationPushAsync(Page page, bool animated);
        Task NavigationPushModalAsync(Page page);
        Task NavigationPushModalAsync(Page page, bool animated);

        Task NavigationPopAsync();
        Task NavigationPopAsync(bool animated);
        Task NavigationPopModalAsync();
        Task NavigationPopModalAsync(bool animated);
    }
}
