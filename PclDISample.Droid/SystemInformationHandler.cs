using PclDISample.Core;

namespace PclDISample.Droid
{
    internal class SystemInformationHandler:ISystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        //public string OSVersion => System.Environment.OSVersion.ToString();
        public string OSVersion => $"Android {Android.OS.Build.VERSION.SdkInt} {Android.OS.Build.VERSION.Release}";

        #endregion
    }
}