namespace netxapp.Services
{
    partial class RemoteGattServer
    {
       
        private void PlatformInit()
        {
            throw new NotImplementedException();
        }
                        
        bool GetConnected()
        {
            throw new NotImplementedException();
        }

        private async Task<bool> WaitForServiceDiscovery()
        {
            throw new NotImplementedException();
        }

        Task PlatformConnect()
        {
            throw new NotImplementedException();
        }

        void PlatformDisconnect()
        {
            throw new NotImplementedException();
        }

        void PlatformCleanup()
        {
            throw new NotImplementedException();
        }

        async Task<GattService> PlatformGetPrimaryService(BluetoothUuid service)
        {
            throw new NotImplementedException();
        }

        async Task<List<GattService>> PlatformGetPrimaryServices(BluetoothUuid? service)
        {
            throw new NotImplementedException();
        }

        Task<short> PlatformReadRssi()
        {
            throw new NotImplementedException();
        }

        

        bool PlatformRequestMtu(int mtu)
        {
            throw new NotImplementedException();
        }
    }
}
