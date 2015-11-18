using System;
using GalaSoft.MvvmLight;

namespace PclDISample.Core.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ISystemInformationHandler _systemInformationHandler;

        public MainViewModel(ISystemInformationHandler systemInformationHandler)
        {
            if (systemInformationHandler == null) throw new ArgumentNullException(nameof(systemInformationHandler));
            _systemInformationHandler = systemInformationHandler;
        }

        public string OSVersion => _systemInformationHandler.OSVersion;
    }
}