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
        readonly Random random;
        int itemNumber = 1;

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => base.SetProperty(ref _isRefreshing, value);
        }

        public ICommand RefreshCommand { get; private set; }

        public ObservableCollection<Item> Items { get; private set; }

        public RefreshViewViewModel()
        {
            random = new Random();
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

        void AddItems()
        {
            for (int i = 0; i < 50; i++)
            {
                Items.Add(new Item
                {
                    Color = Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)),
                    Name = $"Item {itemNumber++}"
                });
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }
}
