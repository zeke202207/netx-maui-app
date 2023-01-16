using CommunityToolkit.Maui.Views;
using netxapp.Controls.BusyIndicator;
using netxapp.ViewModels;
using System.ComponentModel;

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
    private readonly BaseViewModel _baseViewModel;
    private SpinnerPopup _popup;

    public BaseContentPage(BaseViewModel viewModel = null)
    {
        BindingContext = viewModel;
        base.Title = viewModel.Title;
        _baseViewModel = viewModel;
        viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_baseViewModel.IsBusy))
        {
            if (null == _popup)
                _popup = new SpinnerPopup();
            if (_baseViewModel.IsBusy)
                this.ShowPopup(_popup);
            else
            {
                _popup.Close();
                _popup = null;
            }
        }
        OnPropertyChanged(sender, e);
    }

    protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    { }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}


