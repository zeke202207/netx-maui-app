using NetX.AppCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetX.AppLauncher.ViewModel
{
    internal class ButtonViewModel : BaseViewModel
    {
        public ICommand NoParamCommand { get; private set; }
        public ICommand ParamCommand { get;private set; }

        internal ButtonViewModel()
        {
            NoParamCommand = base.CreateAsyncCommand(NoParamCommandExecute);
            ParamCommand = base.CreateAsyncCommand<string>(ParamCommandExecute);
        }

        private async Task ParamCommandExecute(string commandParam)
        {
            
        }

        private async Task NoParamCommandExecute()
        {
            
        }
    }
}
