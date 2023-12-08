using NetX.AppCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetX.AppLauncher.ViewModel
{
    public class CollectionViewViewModel : BaseViewModel
    {
        #region CollectionView
        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => base.SetProperty(ref _isRefreshing, value);
        }

        public ObservableCollection<Monkey> Monkeys { get; private set; } = new();
        public ICommand DeleteCommand { get;private set; }
        public ICommand RefreshCommand { get; private set; }

        void Init4()
        {
            for (int i = 0; i < 10; i++)
            {
                Monkeys.Add(new Monkey
                {
                    Name = $"zeke ->{i}",
                    Location = "Africa & Asia",
                    Details = "mytest",
                    ImageUrl = "https://pic.cnblogs.com/avatar/993045/20230428162055.png"
                });
            }

            DeleteCommand = CreateAsyncCommand<string>(async (monkey) =>
            {
                await Task.Delay(1000);
            });

            RefreshCommand = CreateAsyncCommand(async () =>
            {
                IsRefreshing = true;
                await Task.Delay(5000);
                IsRefreshing = false;
            });
        }

        #endregion

        public CollectionViewViewModel()
        {
            Init4();
        }
    }


    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }
}
