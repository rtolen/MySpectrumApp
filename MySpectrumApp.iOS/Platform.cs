using System;
using UIKit;
using Xamarin.Forms;


[assembly: Dependency(typeof(MySpectrumApp.iOS.Platform))]

namespace MySpectrumApp.iOS
{
    public class Platform : Interfaces.IPlatform
    {
        UIDevice device = new UIDevice();

        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return String.Format("{0} {1}", device.SystemName,
                                            device.SystemVersion);
        }
    }
}