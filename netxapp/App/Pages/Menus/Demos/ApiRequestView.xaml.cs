using netxapp.ViewModels.MenusViewModel.Demos;

namespace netxapp.Pages;

public partial class ApiRequestView : BaseContentView
{
    public ApiRequestView()
		:base()
	{
		InitializeComponent();
        base.BindingContext<ApiRequestViewModel>();
	}
}