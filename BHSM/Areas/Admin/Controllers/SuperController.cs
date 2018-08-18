using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Areas.Admin.Controllers
{
    public class SuperController : Controller
    {
        // GET: Admin/Super
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Department() {
           
         return View();
        }
    }
}