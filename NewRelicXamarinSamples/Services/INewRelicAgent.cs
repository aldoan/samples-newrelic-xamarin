using System.Collections.Generic;

namespace NewRelicDemoCapabilities.Services
{
    public interface INewRelicAgent
    {
        void TrackCustomEvent(string eventName, Dictionary<string, string> data);
        void CrashAppNow();
        void AddBreadcrumb();
    }
}
