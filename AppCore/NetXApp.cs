using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public sealed class NetXApp
    {
        public static AppDevice Device { get; } = new AppDevice();

        public static Shell Shell { get; internal set; }
    }
}
