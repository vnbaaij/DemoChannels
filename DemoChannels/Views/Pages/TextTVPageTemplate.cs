using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Web.UI.HtmlControls;

namespace DemoChannels.Views.Pages
{
  [TemplateDescriptor(Inherited = true, Tags = new string[] {"TextTV"})]
  public class TextTVPageTemplate : TemplatePage<PageData>
  {
    protected HtmlHead Head1;
    protected HtmlForm Form1;

    protected void Page_Load(object sender, EventArgs e)
    {
    }
  }
}
