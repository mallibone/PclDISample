using System;
using System.Threading;
using GalaSoft.MvvmLight.Ioc;
using PclDISample.Core;
using PclDISample.iOS.ViewModel;

namespace PclDISample.iOS
{
    internal class Locator : ViewModelLocator
    {
        private static readonly Lazy<Locator> _locator = new Lazy<Locator>(() => new Locator(), LazyThreadSafetyMode.PublicationOnly);
        public static Locator Instance => _locator.Value;

        private Locator()
        {
            SimpleIoc.Default.Register<ISystemInformationHandler, SystemInformationHandler>();
        }
    }
}