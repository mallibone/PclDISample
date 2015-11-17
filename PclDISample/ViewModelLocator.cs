using GalaSoft.MvvmLight.Ioc;
using PclDISample.Core;

namespace PclDISample.UWP
{
    class ViewModelLocator:Core.ViewModel.ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ISystemInformationHandler, SystemInformationHandler>();
        }
    }
}
