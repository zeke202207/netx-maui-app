using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Model
{
    public class ShellConfig
    {
        public List<NetXShellContent> Contents { get; set; }

        public NetXShellMenu Menu { get; set; }

        public DataTemplate Footer { get; set; }

        public DataTemplate Header { get; set; }

        public bool NavBarIsVisible { get; set; } = false;
    }

    public class NetXShellContent : BaseNetXShell
    {
        public DataTemplate ContentTemplate { get; set; }
    }

    public class NetXShellMenu : BaseNetXShell 
    {
        public List<NetXShellMenuItem> Menus { get; set; }
    }

    public class NetXShellMenuItem : BaseNetXShell
    {
        public DataTemplate ContentTemplate { get; set; }

        public SearchHandler SearchHandler { get; set; }
    }

    public class BaseNetXShell
    {
        public string Title { get; set; }
        public ImageSource Icon { get; set; }
        public int Order { get; set; }
        public string Route { get; set; }
        public bool FlyoutItemIsVisible { get; set; } = true;
    }
}
