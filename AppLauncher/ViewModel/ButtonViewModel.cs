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
        private bool _defaultChecked = true;
        public bool DefaultChecked
        {
            get => _defaultChecked;
            set => base.SetProperty(ref _defaultChecked, value);
        }

        private string _selecedItem = string.Empty;
        public string SelecedItem
        {
            get => _selecedItem;
            set => base.SetProperty(ref _selecedItem, value);
        }
        private string _groupName = "zeke";
        public string GroupName
        {
            get=> _groupName;
            set=> base.SetProperty(ref _groupName, value);
        }

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
