using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using Umbraco.Core.Models;
using UmbracoRetro.Models;
using System.Linq;

namespace UmbracoRetro.Controllers
{
    public class BlogController : SurfaceController
    {
        public ActionResult RenderPostList(int numberOfItems)
        {
            List<BlogPreview> model = new List<BlogPreview>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            IPublishedContent blogPage = homePage.Children.Where(x => x.DocumentTypeAlias == "blog").FirstOrDefault();
           
            //code to get the current page using helper
            //UmbracoHelper umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            //IPublishedContent blogPage = CurrentPage.AncestorOrSelf("blog");
            //IPublishedContent blogPage = Umbraco.AssignedContentItem.AncestorOrSelf("blog");

            if (blogPage != null)
            {
                foreach (IPublishedContent page in blogPage.Children.OrderByDescending(x => x.UpdateDate).Take(numberOfItems))
                {
                    var imageId = page.GetPropertyValue<string>("articleImage");
    
                    var mediaItem = Umbraco.Media(imageId);
                    //page.Url is alink to the article/child of blog 
                    model.Add(new BlogPreview(page.Name, page.GetPropertyValue<string>("articleIntro"), mediaItem.Url, page.Url));
                }
            }

            return PartialView("~/Views/Partials/Blog/_PostList.cshtml", model);
        }
    }
}