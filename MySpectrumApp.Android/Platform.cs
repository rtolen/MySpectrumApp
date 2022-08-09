using System;
using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(MySpectrumApp.Droid.Platform))]

namespace MySpectrumApp.Droid
{
    public class Platform : Interfaces.IPlatform
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", Build.Manufacturer,
                                            Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}