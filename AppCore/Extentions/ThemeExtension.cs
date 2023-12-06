using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public static class ThemeExtension
    {
        public static Shell InitTheme(this Shell shell, Theme theme)
        {
            ThemeManager.Instance.ChangeTheme(theme);
            return shell;
        }
    }
}
