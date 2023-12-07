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

        public static Theme Theme { get; internal set; }

        public static void RefreshTheme()
        {
            if (Application.Current.Resources.TryGetValue("WindowBackgroundColor", out var flyoutBackgroundColor))
            {
                Shell.SetValue(Shell.FlyoutBackgroundColorProperty, (Color)flyoutBackgroundColor);
                //Shell.SetValue(Shell.TabBarBackgroundColorProperty, (Color)flyoutBackgroundColor);
            }
        }
    }
}
