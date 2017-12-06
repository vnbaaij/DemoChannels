using EPiServer.Web;
using System.Web;

namespace DemoChannels.Business.Channels
{
    public class TextTVChannel : DisplayChannel
    {
        public override string ChannelName
        {
            get { return "TextTV"; }
        }

        public override string DisplayName
        {
            get { return "Text TV"; }
        }

        public override string ResolutionId
        {
            get { return typeof(TextTVResolution).FullName; }
        }

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.UserAgent.Contains("TextTV");
        }
    }
}
