using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace AppleWatchChannel.Controllers
{
  [TemplateDescriptor(AvailableWithoutTag = false, Inherited = true, TagString = "AppleWatch")]
  public class AppleWatchPageDataController : PageController<PageData>
  {
    public AppleWatchPageDataController() : base()
    {

    }

    public ActionResult Index(PageData currentPage)
    {
      return View("~/modules/AppleWatchChannel/Views/Pages/AppleWatch.cshtml", (object) currentPage);
    }
  }
}
