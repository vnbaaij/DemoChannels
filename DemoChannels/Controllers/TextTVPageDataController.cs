using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace TextTVChannel.Controllers
{
  [TemplateDescriptor(AvailableWithoutTag = false, Inherited = true, TagString = "TextTV")]
  public class TextTVPageDataController : PageController<PageData>
  {
    public ActionResult Index(PageData currentPage)
    {
      return (ActionResult) this.View("~/modules/TextTVChannel/Views/Pages/TextTV.cshtml", (object) currentPage);
    }
  }
}
