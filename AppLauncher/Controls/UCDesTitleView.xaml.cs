namespace NetX.AppLauncher.Controls;

public partial class UCDesTitleView : ContentView
{
    public static readonly BindableProperty DesTitleProperty = BindableProperty.Create(nameof(DesTitle), typeof(string), typeof(UCDesTitleView), string.Empty);

    public string DesTitle
    {
        get => (string)GetValue(UCDesTitleView.DesTitleProperty);
        set => SetValue(UCDesTitleView.DesTitleProperty, value);
    }

    public UCDesTitleView()
	{
		InitializeComponent();
	}
}