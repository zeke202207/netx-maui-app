using netxapp.Services;
using netxapp.ViewModels;
using System.ComponentModel.Design;

namespace netxapp.Pages;

public partial class DemoPage : BaseContentPage
{
    private readonly IRoutingService _router;

    public DemoPage(DemoViewModel viewModel,IRoutingService router)
        : base(viewModel)
	{
        _router = router;
        InitializeComponent();
	}
}