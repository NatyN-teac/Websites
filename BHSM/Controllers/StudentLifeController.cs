using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class StudentLifeController : Controller
    {
        // GET: StudentLife
        public ActionResult eventsActivity()
        {
            return View();
        }
        public ActionResult internationalstu()
        {
            return View();
        }
        public ActionResult graduationGallery()
        {
            return View();

        }
        public ActionResult outreachprogram()
        {
            return View();
        }
    }
}