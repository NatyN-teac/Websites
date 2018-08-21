using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Areas.Admin.Controllers
{
    public class EventController : Controller
    {
        // GET: Admin/Event
        public ActionResult EventIndex()
        {
            return View();
        }

        public ActionResult CreateEvent() {

            return View();
        }
    }
}