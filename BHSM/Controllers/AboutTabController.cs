using BHSM.Models;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;
using System.Linq;

namespace BHSM.Controllers
{
    public class AboutTabController : Controller
    {

        private ApplicationDbContext dbCon;

        public AboutTabController()
        {
            dbCon = new ApplicationDbContext();
        }

        public ActionResult ShowAnswer() {

            var ans = dbCon.EnqueryTables.Where(m => m.Answer != null).ToList();

            return View(ans);
        }


        // GET: AboutTab
        public ActionResult History()
        {
            return View();
        }

        public ActionResult SchoolAtGlance()
        {
            return View();
        }

        public ActionResult SchoolAdmin()
        {
            return View();
        }

        public ActionResult OfficeAndService()
        {
            return View();
        }
        public ActionResult DirectionMap()
        {
            return View();
        }

        public ActionResult EventCalendar()
        {
            return View();
        }
        public ActionResult Graduation()
        {
            return View();
        }
        public ActionResult cultureCampus()
        {
            return View();
        }
        public ActionResult factFigures()
        {
            return View();
        }
        public ActionResult enqury()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(EnqueryTable enq)
        {
            //if (!ModelState.IsValid)
            //{
            //    Response.StatusCode = (int)HttpStatusCode.BadRequest;
            //    return Json("Failed");
            //}

            //else
            //{
            if(!ModelState.IsValid)
            {
                return Content("Error happened");
                

            }
                dbCon.EnqueryTables.Add(enq);

                dbCon.SaveChanges();
            return RedirectToAction("enqury", "AboutTab");


            //Response.StatusCode = (int)HttpStatusCode.OK;
            //return Json("Success");


            //}





        }

        public ActionResult contactUs()
        {
            return View();
        }

    }
}