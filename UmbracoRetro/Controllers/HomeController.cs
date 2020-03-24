using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoRetro.Controllers
{
    public class HomeController : SurfaceController
    {
         public ActionResult RenderFeatured()
        {
            return PartialView("~/Views/Partials/Home/_Featured.cshtml");
        }

        public ActionResult RenderServices()
        {
            return PartialView("~/Views/Partials/Home/_Services.cshtml");
        }

        public ActionResult RenderBlog()
        {
            return PartialView("~/Views/Partials/Home/_Blog.cshtml");
        }

        public ActionResult RenderClients()
        {
            return PartialView("~/Views/Partials/Home/_Clients.cshtml");
        }
    }
}