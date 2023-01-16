using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace netxapp.ViewModels;

public class AllControlsViewModel : BaseViewModel
{
    public ICommand ExecuteSearch { get; set; }

    public AllControlsViewModel()
    {
        ExecuteSearch = new Command(
            execute: async p => await Search(p),
            canExecute: p=> true);
    }

    private async Task Search(object p)
    {
        await Task.CompletedTask;
    }
}
