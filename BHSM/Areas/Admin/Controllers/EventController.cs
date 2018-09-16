using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BHSM.Areas.Admin.ViewModel;

namespace BHSM.Areas.Admin.Controllers
{
    public class EventController : Controller
    {
        // GET: Admin/Event
        public ActionResult EventIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create() {



            return View();
        }
    }
}