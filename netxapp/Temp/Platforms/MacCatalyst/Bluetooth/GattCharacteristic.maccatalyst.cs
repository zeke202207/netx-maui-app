namespace netxapp.Services
{
    partial class GattCharacteristic
    {

        BluetoothUuid GetUuid()
        {
           throw new NotImplementedException();
        }

        GattCharacteristicProperties GetProperties()
        {
            throw new NotImplementedException();
        }

        Task<GattDescriptor> PlatformGetDescriptor(BluetoothUuid descriptor)
        {
            throw new NotImplementedException();
        }

        async Task<IReadOnlyList<GattDescriptor>> PlatformGetDescriptors()
        {
            throw new NotImplementedException();
        }

        byte[] PlatformGetValue()
        {
            throw new NotImplementedException();
        }

        Task<byte[]> PlatformReadValue()
        {
            throw new NotImplementedException();
        }

        Task PlatformWriteValue(byte[] value, bool requireResponse)
        {
            throw new NotImplementedException();
        }

        void AddCharacteristicValueChanged()
        {
            throw new NotImplementedException();
        }

        void RemoveCharacteristicValueChanged()
        {
            throw new NotImplementedException();
        }

        private async Task PlatformStartNotifications()
        {
            throw new NotImplementedException();
        }

        private async Task PlatformStopNotifications()
        {
            throw new NotImplementedException();
        }
    }
}
