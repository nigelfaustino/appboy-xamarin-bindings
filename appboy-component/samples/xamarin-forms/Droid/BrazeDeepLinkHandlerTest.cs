using System;
using Android.Content;
using Com.Appboy;
using Com.Appboy.UI;
using Com.Appboy.UI.Actions;

namespace TestAppXamarinForms.Droid
{
    public class BrazeDeepLinkHandlerTest : AppboyNavigator
    {
        public override void GotoUri(Context context, UriAction uriAction)
        {
            String uri = uriAction.Uri.ToString();
            Console.WriteLine("Received attempt to navigate to: " + uri)
            base.GotoUri(context, uriAction);
        }

        public override int GetIntentFlags(AppboyNavigatorIntentFlagPurpose intentFlagPurpose)
        {
            String intentString = intentFlagPurpose.ToString();
            Console.WriteLine("Printing intent flags:" + intentString);
            return base.GetIntentFlags(intentFlagPurpose);
        }
    }
}