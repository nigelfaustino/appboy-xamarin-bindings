using System;
using Android.Content;
using Com.Appboy.UI;
using Com.Appboy.UI.Actions;

namespace com.appboy.xamarinsample
{
  public class BrazeDeepLinkHandlerTest : AppboyNavigator
  {
    public override void GotoUri (Context context, UriAction uriAction)
    {
      String uri = uriAction.Uri.ToString ();
      Console.WriteLine ("Received attempt to navigate to: " + uri);
    }
  }
}
