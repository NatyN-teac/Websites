using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {

    public ActionResult LandingPage() {


            return View();
    }
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult check() {
            return View();

        }

        public ActionResult newsAndEvents() {
            return View();

        }

        public ActionResult AnswerEnquery() {
            return View();

        }

        public ActionResult DirectMessage() {
            return View();
        }

        public ActionResult Blog() {
            return View();

        }

        public ActionResult Staff() {
            return View();

        }
    }
}