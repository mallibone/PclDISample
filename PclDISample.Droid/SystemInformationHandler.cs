using PclDISample.Core;

namespace PclDISample.Droid
{
    internal class SystemInformationHandler:ISystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        public string OSVersion => System.Environment.OSVersion.ToString();

        #endregion
    }
}