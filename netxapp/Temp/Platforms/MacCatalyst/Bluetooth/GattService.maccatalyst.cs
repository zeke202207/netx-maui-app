namespace netxapp.Services
{
    partial class GattService
    {
       

        private BluetoothUuid GetUuid()
        {
            throw new NotImplementedException();
        }

        private bool GetIsPrimary()
        {
            throw new NotImplementedException();
        }

        private Task<GattCharacteristic> PlatformGetCharacteristic(BluetoothUuid characteristic)
        {
            throw new NotImplementedException();
        }

        private Task<IReadOnlyList<GattCharacteristic>> PlatformGetCharacteristics()
        {
            throw new NotImplementedException();
        }

        private async Task<GattService> PlatformGetIncludedServiceAsync(BluetoothUuid service)
        {
            throw new NotImplementedException();
        }

        private async Task<IReadOnlyList<GattService>> PlatformGetIncludedServicesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
