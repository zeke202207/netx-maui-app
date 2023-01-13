using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace netxapp.ViewModels;

public class BluetoothDemoViewModel : BaseViewModel
{
    private ObservableCollection<BluetoothModel> bluetoothModels = new ObservableCollection<BluetoothModel>();

    public ICommand ExecuteScan { get; set; }
    public ICommand ExcuteConn { get; set; }

    public ObservableCollection<BluetoothModel> BluetoothModels
    {
        get { return bluetoothModels; }
        set { SetProperty(ref bluetoothModels, value); }
    }

    public BluetoothDemoViewModel()
    {
        ExecuteScan = new Command(() => Scan());
        ExcuteConn = new Command(() => Connection(),()=>true);
        BluetoothModels = new ObservableCollection<BluetoothModel>();
        BluetoothModels.Add(new BluetoothModel()
        {
            DeviceName = "zeke",
            DeviceAddress = "test"
        });
        BluetoothModels.Add(new BluetoothModel()
        {
            DeviceName = "zeke1",
            DeviceAddress = "test1"
        });
    }

    private void Connection()
    {
        
    }

    private void Scan()
    {
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
    }
}

public class BluetoothModel
{
    public string DeviceName { get; set; }
    public string DeviceAddress { get; set; }
    public bool IsChecked { get; set; } = false;
}

