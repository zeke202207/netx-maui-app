using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetX.AppCore
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected BaseViewModel()
        {
            
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected ICommand CreateAsyncCommand(Func<Task> execute)
        {
            return new Command(execute: async ()=> await execute?.Invoke());
        }

        protected ICommand CreateAsyncCommand(Func<Task> execute, [NotNull]Func<bool> canexcute)
        {
            return new Command(
                execute: async () => await execute?.Invoke(),
                canExecute: () => canexcute.Invoke());
        }

        protected ICommand CreateAsyncCommand<TParam>(Func<TParam, Task> execute)
        {
            return new Command(execute: async p => await execute?.Invoke((TParam)p));
        }

        protected ICommand CreateAsyncCommand<TParam>(Func<TParam, Task> execute, [NotNull] Func<TParam,bool> canexcute)
            where TParam : class
        {
            return new Command(
                execute: async p => await execute?.Invoke(p as TParam),
                canExecute: p => canexcute.Invoke((TParam)p));
        }
    }
}
