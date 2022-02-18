using Foundation;
using UIKit;
using NewRelicXamarin;

namespace NewRelicXamarinSamples.iOS
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
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            NRLogger.SetLogLevels((uint)NRLogLevels.All);
            NewRelic.StartWithApplicationToken("AAb299d3a6daac734c7b2dfe9779b0a3a54be75c58-NRMA");
            NewRelicXamarin.NewRelic.RecordBreadcrumb("Application Started", null);

            return base.FinishedLaunching(app, options);
        }
    }
}
