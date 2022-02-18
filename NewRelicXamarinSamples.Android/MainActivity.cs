using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace NewRelicXamarinSamples.Droid
{
    [Activity(Label = "NewRelicXamarinSamples", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            var config = new NewRelicXamarin.Android.AgentConfiguration();
            config.ApplicationToken = "AAb299d3a6daac734c7b2dfe9779b0a3a54be75c58-NRMA";
            NewRelicXamarin.Android.AndroidAgentImpl.Init(this, config);
            NewRelicXamarin.Android.Agent.Start();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
