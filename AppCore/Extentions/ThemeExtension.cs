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
            switch (theme)
            {
                case Theme.Light:
                    ChangeTheme(new Resources.Theme.LightTheme());
                    //shell.Resources.MergedDictionaries.Add(new Resources.Theme.LightTheme());
                    break;
                case Theme.Dark:
                    ChangeTheme(new Resources.Theme.DarkTheme());
                    //shell.Resources.MergedDictionaries.Add(new Resources.Theme.DarkTheme());
                    break;
                default:
                    ChangeTheme(new Resources.Theme.LightTheme());
                    //shell.Resources.MergedDictionaries.Add(new Resources.Theme.LightTheme());
                    break;
            }
            //Application.Current.Resources.MergedDictionaries.Add(shell.Resources);
            return shell;
        }

        private static void ChangeTheme<Theme>(Theme theme)
            where Theme : ResourceDictionary
        {
            var themeItem = Application.Current.Resources.MergedDictionaries.FirstOrDefault(p=>p.GetType() == theme.GetType());
            if(null != themeItem)
                Application.Current.Resources.MergedDictionaries.Remove(themeItem);
            Application.Current.Resources.MergedDictionaries.Add(theme);
        }
    }
}
