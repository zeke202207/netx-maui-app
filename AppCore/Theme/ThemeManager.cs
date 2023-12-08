using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public class ThemeManager
    {
        private static Lazy<ThemeManager> _instance = new Lazy<ThemeManager>(() => new ThemeManager());

        private ThemeManager() { }

        public static ThemeManager Instance => _instance.Value;

        public void ChangeTheme(Theme theme)
        {
            Application.Current.UserAppTheme = theme switch
            {
                Theme.Light => AppTheme.Light,
                Theme.Dark => AppTheme.Dark,
                _ => throw new NotImplementedException("为实现的主题")
            };
        }
    }
}
