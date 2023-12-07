using Microsoft.Maui;
using Xaml = Microsoft.UI.Xaml;
using XamlControls = Microsoft.UI.Xaml.Controls;

namespace NetX.AppCore
{
    // All the code in this file is only included on Windows.
    public class NetXTitleBar : XamlControls.StackPanel
    {
        public NetXTitleBar()
        {
            //var grid = new XamlControls.Grid();
            //grid.Name = "netxtitlebar";
            ////Grid 背景透明 
            //grid.Background = new Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Red);

            //var border = new XamlControls.Border();
            //border.Width = 500;
            //border.Child = grid;

            //Children.Add(border);


            //===================================================================================================

            //StackPanel背景透明 Background="Transparent"
            //Windows.UI.Color.FromArgb(100, 255, 0, 0)
            Background = new Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);

            var grid = new XamlControls.Grid();

            //Grid 背景透明 
            grid.Background = new Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);

            grid.Name = "CustomTitleBar";

            /*
              <Grid.RowDefinitions>
                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="*" />
                    </Grid.RowDefinitions>
             */

            //grid.RowDefinitions.Add(new XamlControls.RowDefinition()
            //{
            //    Height = new Xaml.GridLength(1, Xaml.GridUnitType.Auto)
            //});

            grid.RowDefinitions.Add(new XamlControls.RowDefinition()
            {
                Height = new Xaml.GridLength(1, Xaml.GridUnitType.Star)
            });

            /*
                 <Grid.ColumnDefinitions>
                        <ColumnDefinition x:Name="LeftPaddingColumn"
                                          Width="0" />
                        <ColumnDefinition />
                        <ColumnDefinition x:Name="RightPaddingColumn"
                                          Width="0" />
                    </Grid.ColumnDefinitions>
             */

            grid.ColumnDefinitions.Add(new XamlControls.ColumnDefinition()
            {
                Width = new Xaml.GridLength(1, Xaml.GridUnitType.Star)
            });

            var button = new XamlControls.Button()
            {
                Content = "This is a button"
            };

            grid.Children.Add(button);

            XamlControls.Grid.SetColumn(button, 0);
            XamlControls.Grid.SetRow(button, 0);

            var border = new XamlControls.Border();

            //Border 背景颜色
            //border.Background = new Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 255, 1));
            border.Child = grid;

            Children.Add(border);
        }
    }

    public class CustomTitleBar : Microsoft.UI.Xaml.Controls.Grid
    {
        public CustomTitleBar()
        {
            Width = 500;
            Microsoft.UI.Xaml.Controls.Button button = new Microsoft.UI.Xaml.Controls.Button();
            button.Content = "This is a button";
            button.Foreground = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Red);
            button.Width = 100;

            Children.Add(button);
        }
    }
}