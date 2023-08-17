using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Model
{
    public class BaseNetXShell
    {
        public string Title { get; set; }
        public ImageSource Icon { get; set; }
        public int Order { get; set; }
        public string Route { get; set; }
        public bool FlyoutItemIsVisible { get; set; } = true;
    }
}
