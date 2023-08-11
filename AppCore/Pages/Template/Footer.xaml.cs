using NetX.AppCore.Model;

namespace NetX.AppCore.Pages.Template;

public partial class Footer : ContentView
{
    public Footer(ShellConfig config)
    {
        InitializeComponent();
        this.BindingContext = config;
    }
}