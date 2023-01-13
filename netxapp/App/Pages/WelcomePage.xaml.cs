using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class WelcomePage: BaseContentPage
{
    public WelcomePage(WelcomeViewModel viewModel)
        : base(viewModel)
    {
        InitializeComponent();
    }

    internal WelcomeViewModel ViewModel { get; set; } = IPlatformApplication.Current.Services.GetRequiredService<WelcomeViewModel>();

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.Init();
    }
}