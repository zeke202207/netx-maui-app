using NetX.AppCore;

namespace NetX.AppLauncher;

public partial class ThemePage : BaseContentPage
{
	private int i = 0;

	public ThemePage()
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