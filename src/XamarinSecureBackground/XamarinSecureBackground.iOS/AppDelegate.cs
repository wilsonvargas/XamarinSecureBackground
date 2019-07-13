using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace XamarinSecureBackground.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        UIImageView _imageWindows = null;
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        public override void OnActivated(UIApplication application)
        {
            base.OnActivated(application);

            _imageWindows?.RemoveFromSuperview();
            _imageWindows?.Dispose();
            _imageWindows = null;
        }

        public override void OnResignActivation(UIApplication application)
        {
            base.OnResignActivation(application);


            _imageWindows = new UIImageView(UIImage.FromBundle("Default.png"))
            {
                Frame = UIApplication.SharedApplication.KeyWindow.RootViewController.View.Bounds
            };
            UIApplication.SharedApplication.KeyWindow.RootViewController.View.AddSubview(_imageWindows);
        }
    }
}
