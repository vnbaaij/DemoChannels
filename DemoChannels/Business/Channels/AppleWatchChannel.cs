using EPiServer.Web;
using System.Web;

namespace DemoChannels.Business.Channels
{
    public class AppleWatchChannel : DisplayChannel
    {

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.UserAgent.Contains("AppleWatch");
        }

        public override string ChannelName
        {
            get { return "AppleWatch"; }
        }

        public override string ResolutionId
        {
            get { return typeof(AppleWatchResolution).FullName; }
        }

        public override string DisplayName
        {
            get { return "Apple Watch"; }
        }
    }
}
