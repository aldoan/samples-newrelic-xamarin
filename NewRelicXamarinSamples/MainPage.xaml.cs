using System.Collections.Generic;
using NewRelicDemoCapabilities.Services;
using Xamarin.Forms;

namespace NewRelicXamarinSamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Handle_Custom_Event(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You sent {count} events.";
            INewRelicAgent service = DependencyService.Get<INewRelicAgent>();

            var data = new Dictionary<string, string>() {
                { "Name", "Alfonso" },
                { "Lastname", "Dominguez"},
                { "Red", "#FF0000"},
                { "Blue", "#0000FF"}
            };

            service.TrackCustomEvent("DemoEventTriggered", data);

        }


        void Handle_Crash(object sender, System.EventArgs e) {
            ((Button)sender).Text = $"Crashing See You";
            INewRelicAgent service = DependencyService.Get<INewRelicAgent>();
            service.CrashAppNow();
        }

        void Handle_Breadcrumb(object sender, System.EventArgs e) {
            ((Button)sender).Text = $"Breadcrumb sent";
            INewRelicAgent service = DependencyService.Get<INewRelicAgent>();
            service.AddBreadcrumb();
        }
    }
}
