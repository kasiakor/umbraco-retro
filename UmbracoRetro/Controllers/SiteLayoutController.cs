﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using UmbracoRetro.Models;
using System.Runtime.Caching;
using System.Linq;
using Umbraco.Web;

namespace UmbracoRetro.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        /// <summary>
        /// Renders the header navigation partial
        /// </summary>
        /// <returns>Partial view with a model</returns>
        public ActionResult RenderHeader()
        {
            //List<NavigationListItem> nav = GetNavigationModelFromDatabase();
            //use cache if empty usedb
            List<NavigationListItem> nav = GetObjectFromCache<List<NavigationListItem>>("mainNav", 0, GetNavigationModelFromDatabase);
            return PartialView("~/Views/Partials/SiteLayout/_Header.cshtml", nav);
        }

        /// <summary>
        /// Finds the home page and gets the navigation structure based on it and it's children
        /// </summary>
        /// <returns>A List of NavigationListItems, representing the structure of the site.</returns>
        private List<NavigationListItem> GetNavigationModelFromDatabase()
        {
            const int HOME_PAGE_POSITION_IN_PATH = 1;
            int homePageId = int.Parse(CurrentPage.Path.Split(',')[HOME_PAGE_POSITION_IN_PATH]);
            IPublishedContent homePage = Umbraco.Content(homePageId);
            //below is alternative way to find home page
            //IPublishedContent homePage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();
            List<NavigationListItem> nav = new List<NavigationListItem>();
            nav.Add(new NavigationListItem(new NavigationLink(homePage.Url, homePage.Name)));
            // child nav are the remaining links like porfolio, blog ..
            nav.AddRange(GetChildNavigationList(homePage));
            return nav;
        }

        /// <summary>
        /// Loops through the child pages of a given page and their children to get the structure of the site.
        /// </summary>
        /// <param name="page">The parent page which you want the child structure for</param>
        /// <returns>A List of NavigationListItems, representing the structure of the pages below a page.</returns>
        private List<NavigationListItem> GetChildNavigationList(IPublishedContent page)
        {
            List<NavigationListItem> listItems = null;
            // to hide from nav name with the property umbracoHideNav
            var childPages = page.Children.Where("Visible").Where(x => x.Level <=2);
            if (childPages != null && childPages.Any() && childPages.Count() > 0)
            {
                listItems = new List<NavigationListItem>();
                foreach (var childPage in childPages)
                {
                    NavigationListItem listItem = new NavigationListItem(new NavigationLink(childPage.Url, childPage.Name));
                    listItem.Items = GetChildNavigationList(childPage);
                    listItems.Add(listItem);
                }
            }
            return listItems;
        }


        /// <summary>
        /// A generic function for getting and setting objects to the memory cache.
        /// </summary>
        /// <typeparam name="T">The type of the object to be returned.</typeparam>
        /// <param name="cacheItemName">The name to be used when storing this object in the cache.</param>
        /// <param name="cacheTimeInMinutes">How long to cache this object for.</param>
        /// <param name="objectSettingFunction">A parameterless function to call if the object isn't in the cache and you need to set it.</param>
        /// <returns>An object of the type you asked for</returns>
        private static T GetObjectFromCache<T>(string cacheItemName, int cacheTimeInMinutes, Func<T> objectSettingFunction)
        {
            ObjectCache cache = MemoryCache.Default;
            var cachedObject = (T)cache[cacheItemName];
            if (cachedObject == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheTimeInMinutes);
                cachedObject = objectSettingFunction();
                cache.Set(cacheItemName, cachedObject, policy);
            }
            return cachedObject;
        }

        public ActionResult RenderTitleControls()
        {
            return PartialView("~/Views/Partials/SiteLayout/_TitleControls.cshtml");
        }

        public ActionResult RenderIntro()
        {
            return PartialView("~/Views/Partials/SiteLayout/_Intro.cshtml");
        }

        public ActionResult RenderFooter()
        {
            return PartialView("~/Views/Partials/SiteLayout/_Footer.cshtml");
        }

        public ActionResult RenderMetaData()
        {
            SEO model = new SEO();

            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            string domainAddress = homePage.UrlWithDomain();


            //populate title or page name
            string title = CurrentPage.GetPropertyValue<string>("title");
            model.Title = !string.IsNullOrEmpty(title) ? title : CurrentPage.Name;
            model.Description = CurrentPage.HasProperty("description") ? CurrentPage.GetPropertyValue<string>("description") : null;
            //for keyword we can use string, comma separated values
            model.Keywords = CurrentPage.HasProperty("keywords") ? CurrentPage.GetPropertyValue<string>("keywords") : null;

            if(CurrentPage.HasProperty("socialShareImage"))
            {
                int mediaId = CurrentPage.GetPropertyValue<int>("socialShareImage");
                var mediaItem = Umbraco.Media(mediaId);
                model.ImageUrl = domainAddress.TrimEnd('/') + mediaItem.Url;
            }

            model.Url = CurrentPage.UrlWithDomain();


            return PartialView("~/Views/Partials/SiteLayout/_MetaData.cshtml", model);
        }
    }
}