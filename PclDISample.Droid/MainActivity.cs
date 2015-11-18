using Android.App;
using Android.Widget;
using Android.OS;
using PclDISample.Core.ViewModel;

namespace PclDISample.Droid
{
    [Activity(Label = "PclDISample.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region UI Controls

        private TextView OSVersion => FindViewById<TextView>(Resource.Id.OSVersion);

        #endregion

        private MainViewModel VM => Locator.Instance.Main;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            OSVersion.Text = VM.OSVersion;

            var mainViewModel = new MainViewModel(new SystemInformationHandler());
        }
    }
}

