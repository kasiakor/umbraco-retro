using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoRetro.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        public ActionResult RenderHeader()
        {
            return PartialView("~/Views/Partials/SiteLayout/_Header.cshtml");
        }

        public ActionResult RenderFooter()
        {
            return PartialView("~/Views/Partials/SiteLayout/_Footer.cshtml");
        }
    }
}