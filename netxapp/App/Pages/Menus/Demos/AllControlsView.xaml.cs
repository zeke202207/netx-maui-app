using netxapp.ViewModels;

namespace netxapp.Pages;

public partial class AllControlsView : BaseContentView
{
	public AllControlsView()
		:base()
	{
		InitializeComponent();
        base.BindingContext<AllControlsViewModel>();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await base._page.DisplayAlert("Alert", "You have been alerted", "OK");
        bool answer = await base._page.DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        string action = await base._page.DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        string result = await base._page.DisplayPromptAsync("Question 1", "What's your name?");
        string result1 = await base._page.DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
    }
}