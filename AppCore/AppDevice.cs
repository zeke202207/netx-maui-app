using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public sealed class AppDevice
    {
        public string Model() => DeviceInfo.Model;
        public string Manufacturer() => DeviceInfo.Manufacturer;
        public string Name() => DeviceInfo.Name;
        public string VersionString() => DeviceInfo.VersionString;
        public Version Version() => DeviceInfo.Version;
        public DevicePlatform Platform() => DeviceInfo.Platform;
        public DeviceIdiom Idiom() => DeviceInfo.Idiom;
        public DeviceType DeviceType() => DeviceInfo.DeviceType;
        public IDeviceInfo Current() => DeviceInfo.Current;
    }
}
