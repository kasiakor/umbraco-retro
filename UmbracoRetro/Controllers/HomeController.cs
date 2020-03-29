using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using UmbracoRetro.Models;
using Archetype.Models;
using Umbraco.Web;

namespace UmbracoRetro.Controllers
{
    public class HomeController : SurfaceController
    {
         public ActionResult RenderFeatured()
        {
            List<FeaturedItem> model = new List<FeaturedItem>();
            //IPublishedContent homePage = CurrentPage.AncestorOrSelf(1).DescendantOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();
            const int HOME_PAGE_POSITION_IN_PATH = 1;
            int homePageId = int.Parse(CurrentPage.Path.Split(',')[HOME_PAGE_POSITION_IN_PATH]);
            IPublishedContent homePage = Umbraco.Content(homePageId);
            // get the value of hp - featured 
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

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