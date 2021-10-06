using System;
using System.Threading.Tasks;

using Android.App;
using Android.Runtime;

using Com.Braze;
using Com.Braze.Support;
using Firebase.Iid;
using Com.Appboy.UI;

namespace com.appboy.xamarinsample
{
  [Application]
  public class MainApplication : Application
  {
    public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
    {
    }

    public override void OnCreate()
    {
      BrazeLogger.LogLevel = 0;
      RegisterActivityLifecycleCallbacks(new BrazeActivityLifecycleCallbackListener());
      AppboyNavigator.SetAppboyNavigator (new BrazeDeepLinkHandlerTest());

      new Task(RegisterFirebasePush).Start();
    }

    void RegisterFirebasePush() {
      try {
        var token = FirebaseInstanceId.Instance.GetToken("901477453852", "FCM");
        Braze.GetInstance(this).RegisterAppboyPushMessages (token);
        Console.WriteLine("Registered Firebase push token with Braze: " + token);
      } catch (Exception e) {
        Console.WriteLine("Caught exception registering for Firebase push: " + e);
      }
    }
  }
}