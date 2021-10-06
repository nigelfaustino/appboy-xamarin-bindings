using System;
using Com.Appboy;
using Com.Appboy.Models;
using Com.Appboy.UI;
using Com.Appboy.UI.Inappmessage;
using Com.Braze;
using Com.Braze.Models.Inappmessage;
using Com.Braze.UI.Inappmessage;


using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.Dependency (typeof (TestAppXamarinForms.Droid.AppboyPlatformDelegate))]
namespace TestAppXamarinForms.Droid
{
  public class AppboyPlatformDelegate :  Java.Lang.Object, IAppboyPlatformDelegate
  {
    public AppboyPlatformDelegate ()
    {
    }
    public void LogCustomEvent(String eventName) {
            
            Com.Appboy.Appboy.GetInstance (Xamarin.Forms.Forms.Context).LogCustomEvent (eventName);
    }

    public void ShowSlideupIam ()
    {
      InAppMessageSlideup slideup = new InAppMessageSlideup () {
        Message = "This is a slideup",
      };
      BrazeInAppMessageManager.Instance.AddInAppMessage (slideup);
    }

    public void ShowModalIam ()
    {
      InAppMessageModal modal = new InAppMessageModal () {
        Message = "This is a modal",
      };
      BrazeInAppMessageManager.Instance.AddInAppMessage (modal);
    }

    public void ShowFullIam ()
    {
      InAppMessageFull full = new InAppMessageFull () {
        Message = "This is a full"
      };
      BrazeInAppMessageManager.Instance.AddInAppMessage (full);
    }
  }
}

