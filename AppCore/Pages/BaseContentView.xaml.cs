namespace NetX.AppCore;

public partial class BaseContentView : ContentView
{
	public BaseContentView(BaseViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}