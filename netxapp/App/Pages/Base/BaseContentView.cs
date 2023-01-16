using CommunityToolkit.Maui.Views;
using netxapp.Controls.BusyIndicator;
using netxapp.ViewModels;
using System.ComponentModel;

namespace netxapp.Pages;

public abstract class BaseContentView : ContentView
{
    private BaseViewModel _baseViewModel;
    private SpinnerPopup _popup;
    protected Page _page;

    public BaseContentView()
    {

    }

    protected void BindingContext<T>()
        where T : BaseViewModel
    {
        var viewModel = IPlatformApplication.Current.Services.GetService<T>();
        this.Content.BindingContext = viewModel;
        _baseViewModel = viewModel;
        viewModel.PropertyChanged += ViewModel_PropertyChanged;
        _page = Application.Current?.MainPage ?? throw new NullReferenceException();
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_baseViewModel.IsBusy))
        {
            if (null == _popup)
                _popup = new SpinnerPopup();
            if (_baseViewModel.IsBusy)
                _page?.ShowPopup(_popup);
            else
            {
                _popup.Close();
                _popup = null;
            }
        }
        OnPropertyChanged(sender, e);
    }

    protected T GetViewModel<T>() where T : BaseViewModel
    {
        return _baseViewModel as T;
    }

    protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    { }
}
