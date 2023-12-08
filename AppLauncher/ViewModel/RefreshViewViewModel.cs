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
    public class RefreshViewViewModel : BaseViewModel
    {
        #region RefreshViewViewModel

        readonly Random random =new Random();
        int itemNumber = 1;

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => base.SetProperty(ref _isRefreshing, value);
        }

        public ObservableCollection<Item> Items { get; private set; }

        public ICommand RefreshCommand { get; private set; }

        void AddItems()
        {
            for (int i = 0; i < 5; i++)
            {
                Items.Add(new Item
                {
                    Color = Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)),
                    Name = $"Item {itemNumber++}"
                });
            }
        }

        void Ini1()
        {
            Items = new ObservableCollection<Item>();

            RefreshCommand = base.CreateAsyncCommand(async () =>
            {
                IsRefreshing = true;
                await Task.Delay(5000);
                AddItems();
                IsRefreshing = false;
            });
            AddItems();
        }

        #endregion

        #region SwipeViewViewModel

        public ICommand SwipeCommand { get; private set; }

        void Init2()
        {
            PerformSearch = base.CreateAsyncCommand<string>(async text =>
            {
                Console.WriteLine($"Search for {text}");
                await Task.CompletedTask;
            });

        }

        #endregion

        #region SearchHandlerViewModel

        public ICommand PerformSearch { get; private set; }

        void Init3()
        {
            SwipeCommand = base.CreateAsyncCommand<string>(async text =>
            {

                await Task.CompletedTask;
            });
        }

        #endregion

       public RefreshViewViewModel()
        {
            Ini1();
            Init2();
            Init3();
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }

}
