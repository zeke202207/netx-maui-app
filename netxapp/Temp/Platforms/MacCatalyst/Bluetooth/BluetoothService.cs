namespace netxapp.Services
{
    public static partial class BluetoothService
    {       
        public static bool PlatformIsEnabled()
        {
            throw new NotImplementedException();
        }

        private static async Task<IReadOnlyCollection<BluetoothDevice>> PlatformScanForDevices(string deviceName = "")
        {
            throw new NotImplementedException();
        }


        public static async Task PlatformSendDataAsync(string deviceName, Guid servicesUuid, Guid? characteristicsUuid, byte[] dataBytes, EventHandler<GattCharacteristicValueChangedEventArgs> gattCharacteristicValueChangedEventArgs)
        {
            throw new NotImplementedException();
        }

        public static async Task<PermissionStatus> PlatformCheckAndRequestBluetoothPermission()
        {
            throw new NotImplementedException();
        }
       
        
        static Task<bool> PlatformGetAvailability()
        {
            throw new NotImplementedException();
        }


        private static async void AddAvailabilityChanged()
        {
            throw new NotImplementedException();
        }

        private static void RemoveAvailabilityChanged()
        {
            throw new NotImplementedException();
        }
    }
}
