using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Commuter.Droid
{
    [Activity(Label = "Commuter", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        //public override async void OnRequestPermissionsResult(int requestCode, string[] permissions,
        //    [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    await PermissionsImplementation.Current.RequestPermissionsAsync();
        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}

