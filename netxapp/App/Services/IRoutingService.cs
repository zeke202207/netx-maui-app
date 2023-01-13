using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Services
{
    public interface IRoutingService
    {
        Task GoBack();
        Task GoBackModal();
        Task NavigateTo(string route);
    }
}
