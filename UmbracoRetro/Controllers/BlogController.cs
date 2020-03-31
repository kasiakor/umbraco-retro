using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;



namespace UmbracoRetro.Controllers
{
    public class BlogController : SurfaceController
    {
        public ActionResult RenderPostList()
        {
            return PartialView("~/Views/Partials/Blog/_PostList.cshtml");
        }
    }
}