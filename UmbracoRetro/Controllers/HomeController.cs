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
            //IPublishedContent homePage = Umbraco.AssignedContentItem.AncestorOrSelf(1);
            const int HOME_PAGE_POSITION_IN_PATH = 1;
            int homePageId = int.Parse(CurrentPage.Path.Split(',')[HOME_PAGE_POSITION_IN_PATH]);
            IPublishedContent homePage = Umbraco.Content(homePageId);
            // get the value of hp - featured 
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

            foreach(ArchetypeFieldsetModel fieldset in featuredItems)
            {
                var imageId = fieldset.GetValue<string>("image");
                var mediaItem = Umbraco.Media(imageId);
                string imageUrl = mediaItem.Url;

                var pageId = fieldset.GetValue<string>("page");
                IPublishedContent linkedToPage = Umbraco.TypedContent(pageId);
                string linkUrl = "";

                if (linkedToPage != null)
                {
                    linkUrl = linkedToPage.Url;
                }
                

                model.Add(new FeaturedItem(fieldset.GetValue<string>("name"), fieldset.GetValue<string>("category"), imageUrl, linkUrl));

            }
                

            // pass this model to the partial view
            return PartialView("~/Views/Partials/Home/_Featured.cshtml", model);
        }

        public ActionResult RenderServices()
        {
            return PartialView("~/Views/Partials/Home/_Services.cshtml");
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
                foreach(ArchetypeFieldsetModel testimonial in testimonialList)
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