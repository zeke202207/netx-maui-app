using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher;

public partial class ThemePage : BaseContentPage
{
	private int i = 0;

	public ThemePage()
		:base(new ThemeViewModel())
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (i++ % 2 == 0)
			ThemeManager.Instance.ChangeTheme(Theme.Light);
		else
            ThemeManager.Instance.ChangeTheme(Theme.Dark);
    }
}