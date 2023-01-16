namespace netxapp.Services
{
    partial class GattDescriptor
    {
        BluetoothUuid GetUuid()
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

        Task PlatformWriteValue(byte[] value)
        {
            throw new NotImplementedException();
        }
    }
}
