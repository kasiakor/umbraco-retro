using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoRetro.Library.Models;

namespace UmbracoRetro.Library.Helpers
{
    public class HomeHelper
    {

        private IPublishedContent _currentPage;
        private UmbracoHelper _uHelper;
        // with UmbracoHelper we can use Umbraco.Content or Umbraco.Media
        public HomeHelper(IPublishedContent currentPage, UmbracoHelper uHelper)
        {
            _currentPage = currentPage;
            _uHelper = uHelper;

        }

        public List<FeaturedItem> GetFeaturedItemsModel()
        {
            List<FeaturedItem> model = new List<FeaturedItem>();
            //IPublishedContent homePage = Umbraco.AssignedContentItem.AncestorOrSelf(1);
            const int HOME_PAGE_POSITION_IN_PATH = 1;
            int homePageId = int.Parse(CurrentPage.Path.Split(',')[HOME_PAGE_POSITION_IN_PATH]);
            IPublishedContent homePage = Umbraco.Content(homePageId);
            // get the value of hp - featured 
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

            foreach (ArchetypeFieldsetModel fieldset in featuredItems)
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

            return model;
        }
    }
}
