using System;
using Windows.Devices.Geolocation;
using Windows.Devices.Display;
using Windows.Devices.Enumeration;
using System.Runtime.Versioning;

//[assembly: global::System.Runtime.Versioning.SupportedOSPlatform("Windows10.0.18362.0")]
namespace LightUpExample
{
    public class Example
    {
        //[SupportedOSPlatform("Windows10.0.17134.0")]
        public async void UseDeviceApi()
        {
            if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17134, 0))
            {
                var deviceInformations = await DeviceInformation.FindAllAsync(DisplayMonitor.GetDeviceSelector());
                foreach (DeviceInformation device in deviceInformations)
                {
                    DisplayMonitor displayMonitor = await DisplayMonitor.FromInterfaceIdAsync(device.Id);
                    // Print some info about the display monitor
                    var x = "DisplayName: " + displayMonitor.DisplayName;
                    var y = "ConnectionKind: " + displayMonitor.ConnectionKind;


                    if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 19041, 0))
                    {
                        var z = "IsDolbyVisionSupported: " + displayMonitor.IsDolbyVisionSupportedInHdrMode;
                    }
                }
            }
            
        }
    }
}
