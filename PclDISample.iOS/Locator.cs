using PclDISample.Core.ViewModel;
using System;
using GalaSoft.MvvmLight.Ioc;
using PclDISample.Core;
using System.Threading;

namespace PclDISample.iOS
{
    internal class Locator:ViewModelLocator
    {
        private static Lazy<Locator> _locator = new Lazy<Locator>(() => new Locator(), LazyThreadSafetyMode.PublicationOnly);
        public static Locator Instance => _locator.Value;

        private Locator()
        {
            SimpleIoc.Default.Register<ISystemInformationHandler, SystemInformationHandler>();
        }
    }
}