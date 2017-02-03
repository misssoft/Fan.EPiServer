using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CMS.Models.Commerce;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace CMS.Controllers
{
    public class SiteVariationController : ContentController<SiteVariation>
    {
        public ActionResult Index(SiteVariation currentContent)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentContent);
        }
    }
}