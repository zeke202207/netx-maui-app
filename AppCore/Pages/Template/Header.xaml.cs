using NetX.AppCore.Model;

namespace NetX.AppCore.Pages.Template;

public partial class Header : ContentView
{
	public Header(ShellConfig config)
	{
		InitializeComponent();
		this.BindingContext = config;
	}
}