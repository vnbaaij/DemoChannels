using EPiServer.Web;

namespace DemoChannels.Business.Channels
{
    public class AppleWatchResolution : IDisplayResolution
    {
        public int Height
        {
            get { return 380; }
        }

        public string Id
        {
            get { return this.GetType().FullName; }
        }

        public string Name
        {
            get { return "Apple Watch (290x380)"; }
        }

        public int Width
        {
            get { return 290; }
        }
    }
}
