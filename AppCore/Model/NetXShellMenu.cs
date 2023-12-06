using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Model
{
    public class NetXShellMenu : BaseNetXShell
    {
        public FlyoutBehavior MenuFlyout { get; set; } = FlyoutBehavior.Flyout;

        public int FlyoutWidth { get; set; } = 200;

        public List<NetXShellMenuItem> Menus { get; set; }
    }
}
