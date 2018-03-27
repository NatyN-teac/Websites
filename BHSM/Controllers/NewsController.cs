using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult news()
        {
            return View();
        }
        public ActionResult socialmedias()
        {
            return View();
        }
    }
}