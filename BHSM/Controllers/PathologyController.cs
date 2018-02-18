using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class PathologyController : Controller
    {
        // GET: Pathology
        public ActionResult PathoIndex()
        {
            return View();
        }
    }
}