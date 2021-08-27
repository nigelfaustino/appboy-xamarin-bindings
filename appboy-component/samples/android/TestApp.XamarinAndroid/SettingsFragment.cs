using System;

using AndroidX.Fragment.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace com.appboy.xamarinsample
{
  public class SettingsFragment : Fragment
  {
    public override void OnCreate (Bundle savedInstanceState)
    {
      base.OnCreate (savedInstanceState);

      // Create your fragment here
    }

    public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      if (container == null) {
        return null;
      }
      var textView = new TextView (Activity);
      var padding = Convert.ToInt32 (TypedValue.ApplyDimension (ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics));
      textView.SetPadding (padding, padding, padding, padding);
      textView.TextSize = 24;
      textView.Text = "Settings";

      var scroller = new ScrollView (Activity);
      scroller.AddView (textView);

      return scroller;
    }
  }
}
