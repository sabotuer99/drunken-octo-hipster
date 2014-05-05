using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFoodGit.Filters;

namespace OdeToFoodGit.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        //[Authorize]
        [Log]
        public ActionResult Search(string name)
        {

            var message = Server.HtmlEncode(name);

            return Content(message);
        }

    }
}
