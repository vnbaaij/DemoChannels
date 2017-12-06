using EPiServer.Web;

namespace DemoChannels.Business.Channels
{
    public class TextTVResolution : IDisplayResolution
    {
        public int Height
        {
            get { return 300; }
        }

        public string Id
        {
            get { return this.GetType().FullName; }
        }

        public string Name
        {
            get { return "Text TV (400x300)"; }
        }

        public int Width
        {
            get { return 400; }
        }
    }
}
