using System;
using Android.App;
using Android.Runtime;
using Android.Content;

using Com.Appboy;
using Com.Appboy.UI;
using Com.Appboy.Support;
using Com.Appboy.Push;
using Com.Braze;
using Com.Braze.UI.Inappmessage.Listeners;
using Com.Braze.Push;

namespace TestAppXamarinForms.Droid
{
  [Application]
  public class MainApplication : Application
  {
        public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
    {
    }

    public override void OnCreate ()
    {
      AppboyLogger.LogLevel = 2;
      RegisterActivityLifecycleCallbacks (new AppboyLifecycleCallbackListener ());
            AppboyNavigator.SetAppboyNavigator(new CustomAppboyNavigator());
        
    }
  }
}
