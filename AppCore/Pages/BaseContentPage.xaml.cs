namespace NetX.AppCore;

public partial class BaseContentPage : ContentPage
{
	public BaseContentPage(BaseViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
    }
}