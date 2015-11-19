using PclDISample.Core;

namespace PclDISample.iOS
{
    internal class SystemInformationHandler:ISystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        //public string OSVersion => System.Environment.OSVersion.ToString();
		public string OSVersion => $"iOS {ObjCRuntime.Constants.Version}" ;

        #endregion
    }
}