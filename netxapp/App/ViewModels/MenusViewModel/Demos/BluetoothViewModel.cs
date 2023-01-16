using InTheHand.Bluetooth;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace netxapp.ViewModels;

/*
 *  参考： 
 *  https://inthehand.com/2022/12/01/12-days-of-bluetooth-1-introduction/
 *  https://segmentfault.com/a/1190000042518175
 *  https://github.com/BlazorComponent/MASA.Blazor/tree/main/src/Masa.Blazor.Maui.Plugin/Masa.Blazor.Maui.Plugin.Bluetooth
 */
public class BluetoothViewModel : BaseViewModel
{
    private ObservableCollection<BluetoothModel> bluetoothModels = new ObservableCollection<BluetoothModel>();

    public ICommand ExecuteScan { get; set; }
    public ICommand ExcuteConn { get; set; }

    public ObservableCollection<BluetoothModel> BluetoothModels
    {
        get { return bluetoothModels; }
        set { SetProperty(ref bluetoothModels, value); }
    }

    public BluetoothViewModel()
    {
        ExecuteScan = new Command(() => Scan());
        ExcuteConn = new Command(() => Connection(), () => true);
        BluetoothModels = new ObservableCollection<BluetoothModel>();
        BluetoothModels.Add(new BluetoothModel()
        {
            DeviceName = "zeke",
            DeviceAddress = "test"
        });
    }

    private void Connection()
    {

    }

    private async Task Scan()
    {
        //FOR TEST
        BluetoothModels.Add(new BluetoothModel()
        {
            DeviceName = "zeke1",
            DeviceAddress = "test1"
        });
        var allDevices = await Bluetooth.ScanForDevicesAsync();
        foreach (var device in allDevices)
        {
            BluetoothModels.Add(new BluetoothModel()
            {
                 DeviceName = device.Name,
                 DeviceAddress = device.Gatt.ToString()
            });
        }

        //RequestDeviceOptions options = new RequestDeviceOptions();
        //options.AcceptAllDevices = true;
        //BluetoothDevice device = await Bluetooth.RequestDeviceAsync(options);
        //if (device != null)
        //{
        //    await device.Gatt.ConnectAsync();
        //}
        /*
        using (BluetoothClient client = new BluetoothClient())
        {
            var test = client.PairedDevices;
            var test1 = client.DiscoverDevices(10);

            BluetoothDeviceInfo device = null;
            foreach (var dev in client.DiscoverDevices())
            {
                BluetoothModels.Add(new BluetoothModel()
                {
                    DeviceName = dev.DeviceName,
                    DeviceAddress = dev.DeviceAddress.ToString(),
                });

                //if (dev.DeviceName.Contains("PREFIX"))
                //{
                //    device = dev;
                //    break;
                //}
            }
            //if (!device.Authenticated)
            //    BluetoothSecurity.PairRequest(device.DeviceAddress, "1234");
            //device.Refresh();
            //client.Connect(device.DeviceAddress, BluetoothService.SerialPort);
            //var stream = client.GetStream();
            //StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.ASCII);
            //sw.WriteLine("Hello world!\r\n\r\n");
            //sw.Close();
        }
        */
    }
}

public class BluetoothModel
{
    public string DeviceName { get; set; }
    public string DeviceAddress { get; set; }
    public bool IsChecked { get; set; } = false;
}