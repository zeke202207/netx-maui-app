using netxapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Pages;

/*
public abstract class BasePage<TViewModel> : BaseContentPage
    where TViewModel : BaseViewModel
{
    public BasePage(TViewModel viewModel)
        : base(viewModel)
    { 
    
    }

    public new TViewModel BindingContext => (TViewModel)base.BindingContext;
}
*/

public abstract class BaseContentPage : ContentPage
{
    public BaseContentPage(BaseViewModel viewModel = null)
    {
        BindingContext = viewModel;
        base.Title= viewModel.Title;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}
