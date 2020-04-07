using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web;

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
    }
}
