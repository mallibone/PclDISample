using PclDISample.Core;
using UIKit;

namespace PclDISample.iOS
{
    internal class SystemInformationHandler:ISystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        public string OSVersion => $"iOS {ObjCRuntime.Constants.Version}";

        #endregion
    }
}