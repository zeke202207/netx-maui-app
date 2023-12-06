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
            ResourceDictionary themeResource = theme switch
            {
                Theme.Light => new Resources.Theme.LightTheme(),
                Theme.Dark => new Resources.Theme.DarkTheme(),
                _ => throw new NotImplementedException("为实现的主题")
            };
            var themeItem = Application.Current.Resources.MergedDictionaries.FirstOrDefault(p => p.GetType() == theme.GetType());
            if (null != themeItem)
                Application.Current.Resources.MergedDictionaries.Remove(themeItem);
            Application.Current.Resources.MergedDictionaries.Add(themeResource);
            NetXApp.Theme = theme;
            NetXApp.RefreshTheme();
        }
    }
}
