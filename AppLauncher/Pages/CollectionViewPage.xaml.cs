using NetX.AppCore;
using NetX.AppLauncher.ViewModel;

namespace NetX.AppLauncher.Pages;

public partial class CollectionViewPage : BaseContentPage
{
	public CollectionViewPage()
		:base(new CollectionViewViewModel())
	{
		InitializeComponent();
	}

    void OnCollectionViewRemainingItemsThresholdReached(object sender, EventArgs e)
    {
        var viewModel = BindingContext as CollectionViewViewModel;

		viewModel.Monkeys.Add(new Monkey()
		{
			Name = $"zeke ->{viewModel.Monkeys.Count}",
			Details = "mytest",
			ImageUrl = "https://pic.cnblogs.com/avatar/993045/20230428162055.png",
			Location = "Africa & Asia"
		});
    }
}