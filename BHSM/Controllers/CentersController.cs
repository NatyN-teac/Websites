using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class CentersController : Controller
    {
        // GET: Centers
        public ActionResult diabetics()
        {
            return View();
        }
        public ActionResult ethicCenter()
        {
            return View();
        }
        public ActionResult infectiosDes()
        {
            return View();
        }
        public ActionResult cardiacCenter()
        {
            return View();
        }
    }
}