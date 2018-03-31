![Braze Logo](https://github.com/Appboy/appboy-xamarin-bindings/blob/master/braze-logo.png)

# Xamarin Bindings SDK

Successful marketing automation is essential to the future of your mobile app. Braze helps you engage your users beyond the download. Visit the following links for details and we'll have you up and running in no time!

- [Braze Academy](http://www.braze.com/academy "Braze Academy")
- [Technical Documentation](http://documentation.braze.com "Braze Technical Documentation")
- [Android JavaDocs](http://appboy.github.io/appboy-android-sdk/javadocs/ "Braze Android SDK Class Documentation")
- [iOS Full Class Documentation](http://appboy.github.io/appboy-ios-sdk/docs/annotated.html "Braze iOS SDK Class Documentation")
- [iOS Xamarin Bindings Nuget Package](https://www.nuget.org/packages/AppboyPlatformXamariniOSBinding/ "iOS Xamarin Bindings Nuget Package")
- [Android Xamarin Bindings Nuget Package](https://www.nuget.org/packages/AppboyPlatform.AndroidBinding/ "Android Xamarin Bindings Nuget Package")

## Components

The format of this repository is that of a Xamarin component:  under appboy-component you will find the directories src,
libs, component, and samples.  Libs, src, and samples each contain two directories, one for Android and one for iOS.  The directories
contains:

- libs:  the compiled DLL bindings for the Braze SDKs.
- src:  the Xamarin bindings projects that generated the DLLs found in the libs folder.
- samples:  Xamarin applications that show how to use the bindings to access the Braze feature set.
- nuget: Nuspec files for our Xamarin Nuget packages.
- component:  this contains the information required generate the Xamarin component found in the component store. Note that Braze Xamarin SDK `v1.5.0` is the last version to receive a Xamarin component store release. Future releases will be released to Nuget and the open source repo only.

## Version Support

The Android SDK supports Android 4.0+ (Ice Cream Sandwich and up).  The iOS SDK supports iOS 8.0+.

## Questions?

If you have questions, please contact [support@braze.com](mailto:support@braze.com).
