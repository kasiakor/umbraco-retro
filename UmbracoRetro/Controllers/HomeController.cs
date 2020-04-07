using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using UmbracoRetro.Models;
using Archetype.Models;
using Umbraco.Web;
using System.Linq;
using UmbracoRetro.Library.Models;

namespace UmbracoRetro.Controllers
{
    public class HomeController : SurfaceController
    {
        private const int MAXIMUM_TESTIMONIALS = 2;
        public ActionResult RenderFeatured()
        {
            List<FeaturedItem> model = GetFeaturedItemsModel();

            // pass this model to the partial view
            return PartialView("~/Views/Partials/Home/_Featured.cshtml", model);
        }

       

        public ActionResult RenderServices()
        {
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            string title = homePage.GetPropertyValue<string>("servicesTitle");
            string subtitle = homePage.GetPropertyValue("servicesSubtitle").ToString();
            string category = homePage.GetPropertyValue<string>("categoryName");
            string description = homePage.GetPropertyValue("categoryDescription").ToString();

            Service model = new Service(title, subtitle, category, description);
            return PartialView("~/Views/Partials/Home/_Services.cshtml", model);
        }

        public ActionResult RenderBlog()
        {
            
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            string title = homePage.GetPropertyValue<string>("lastBlogPostsTitle");
            string introduction = homePage.GetPropertyValue("lastBlogPostsIntroduction").ToString();

            LastBlogPosts model = new LastBlogPosts(title, introduction);
            return PartialView("~/Views/Partials/Home/_Blog.cshtml", model);
        }

        public ActionResult RenderTestimonials()
        {
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            string title = homePage.GetPropertyValue<string>("testimonialsTitle");
            string introduction = homePage.GetPropertyValue("testimonialsIntroduction").ToString();

            List<Testimonial> testimonials = new List<Testimonial>();

            // get the testimonialList from Umbraco, type archetype 
            ArchetypeModel testimonialList = homePage.GetPropertyValue<ArchetypeModel>("testimonialList");

            if(testimonialList != null)
            {
                foreach(ArchetypeFieldsetModel testimonial in testimonialList.Take(MAXIMUM_TESTIMONIALS))
                {
                    string name = testimonial.GetValue<string>("name");
                    string quote = testimonial.GetValue<string>("quote");
                    testimonials.Add(new Testimonial(quote, name));
                }
            }

            Testimonials model = new Testimonials(title, introduction, testimonials);
            return PartialView("~/Views/Partials/Home/_Testimonials.cshtml", model);
        }
    }
}