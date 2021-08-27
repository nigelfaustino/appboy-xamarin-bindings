using Android.OS;

using AndroidX.Fragment.App;

namespace com.appboy.xamarinsample
{
  [Android.App.Activity (Label = "TestApp.XamarinAndroid", Icon = "@drawable/icon", Name = "com.appboy.xamarinsample.SettingsActivity")]
  public class SettingsActivity : FragmentActivity
  {
    protected override void OnCreate (Bundle bundle)
    {
      base.OnCreate (bundle);
      SetContentView (Resource.Layout.Main);

      FragmentTransaction fragmentTransaction = SupportFragmentManager.BeginTransaction ();
      SettingsFragment settingsFragment = new SettingsFragment ();
      fragmentTransaction.Add (com.appboy.xamarinsample.Resource.Id.root, settingsFragment, settingsFragment.Class.ToString ());
      fragmentTransaction.Commit ();
    }
  }
}

