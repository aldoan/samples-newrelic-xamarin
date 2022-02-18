using System;
using System.Collections.Generic;
using NewRelicDemoCapabilities.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(NewRelicDemoCapabilities.Droid.Services.NewRelicAgent))]
namespace NewRelicDemoCapabilities.Droid.Services
{
    public class NewRelicAgent : INewRelicAgent
    {
        public void AddBreadcrumb()
        {
            NewRelicXamarin.Android.NewRelic.RecordBreadcrumb("Adding an extra Breadcrumb");
        }

        public void CrashAppNow()
        {
            NewRelicXamarin.Android.NewRelic.RecordBreadcrumb("User crashed the app");
            string[] stringArray = new string[0];
            var x = stringArray[1];
        }

        public void TrackCustomEvent(string eventName, Dictionary<string, string> data)
        {
            
            IDictionary<string, Java.Lang.Object> myDictionary = new Dictionary<string, Java.Lang.Object>();
            
            foreach (KeyValuePair<string, string> entry in data)
            {
                myDictionary.Add(entry.Key, entry.Value);
            }


            NewRelicXamarin.Android.NewRelic.RecordCustomEvent("User tapped sign in button", eventName, myDictionary);


        }
    }
}