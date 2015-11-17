using System;
using GalaSoft.MvvmLight;

namespace PclDISample.Core.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly ISystemInformationHandler _systemInformationHandler;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ISystemInformationHandler systemInformationHandler)
        {
            if (systemInformationHandler == null) throw new ArgumentNullException(nameof(systemInformationHandler));
            _systemInformationHandler = systemInformationHandler;
        }

        public string OSVersion => _systemInformationHandler.OSVersion;
    }
}