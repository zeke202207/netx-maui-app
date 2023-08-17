using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Model
{
    public class ShellConfig
    {
        public HeaderInfo HeaderInfo { get; set; }

        public FooterInfo FooterInfo { get; set; }

        public List<NetXShellContent> Contents { get; set; }

        public NetXShellMenu Menu { get; set; }

        public DataTemplate Footer { get; set; }

        public DataTemplate Header { get; set; }

        public bool NavBarIsVisible { get; set; } = false;
    }
}
