using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.Model
{
    public class NetXShellMenuItem : BaseNetXShell
    {
        public DataTemplate ContentTemplate { get; set; }

        [Obsolete("不在维护此属性")]
        public SearchHandler SearchHandler { get; set; }
    }
}
