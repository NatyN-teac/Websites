using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class AcademicsController : Controller
    {
        // GET: Academics
        public ActionResult AcademicsHome()
        {
            return View();
        }
        public ActionResult medicalEducation()
        {
            return View();

        }
        public ActionResult mdadmission()
        {
            return View();
        }
        public ActionResult graduateEducation()
        {
            return View();
        }

        public ActionResult postDocTraining()
        {
            return View();
        }

        public ActionResult contedu()
        {
            return View();
        }
    }
}