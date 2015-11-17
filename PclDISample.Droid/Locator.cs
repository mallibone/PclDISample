using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Ioc;
using PclDISample.Core;
using PclDISample.Core.ViewModel;

namespace PclDISample.Droid
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