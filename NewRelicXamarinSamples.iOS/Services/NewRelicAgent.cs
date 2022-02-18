using System.Collections.Generic;
using Foundation;
using NewRelicDemoCapabilities.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(NewRelicDemoCapabilities.iOS.Services.NewRelicAgent))]
namespace NewRelicDemoCapabilities.iOS.Services
{
    public class NewRelicAgent : INewRelicAgent
    {
        public void AddBreadcrumb()
        {
            NewRelicXamarin.NewRelic.RecordBreadcrumb("Adding an extra Breadcrumb", null);
        }

        public void CrashAppNow()
        {
            NewRelicXamarin.NewRelic.RecordBreadcrumb("user tapped register button", null);
            string[] stringArray = new string[0];
            var x = stringArray[1];
        }

        public void TrackCustomEvent(string eventName, Dictionary<string, string> data)
        {
            var myDictionary = new NSMutableDictionary();

            foreach (KeyValuePair<string, string> entry in data)
            {
                myDictionary.Add(new NSString(entry.Key), new NSString(entry.Value));
            }

            NewRelicXamarin.NewRelic.RecordCustomEvent(eventName, myDictionary);

        }


    }
}
