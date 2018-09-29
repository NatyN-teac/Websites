using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;
using BHSM.Models;

namespace BHSM.Controllers
{
    public class EnqueryTablesController : Controller
    {
        private ApplicationDbContext _context;
        public EnqueryTablesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: EnqueryTables
        public ActionResult Index()
        {
            var squery = _context.EnqueryTables.ToList();
            return View(squery);
        }

        public ActionResult Save(EnqueryTable query) {
            var message = "";
            if(query.Id == 0) {
                if (!ModelState.IsValid)
                {
                    message = "Cannot save data";
                    // return Json(new { success = false, message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    message = "successfully Submitted";

                    _context.EnqueryTables.Add(query);
                   
                }
            }
            else {
                var dat = _context.EnqueryTables.SingleOrDefault(m => m.Id == query.Id);
                dat.Answer = query.Answer;
                //dat.Question = query.Question;
                //dat.FirstName = query.FirstName;
                //dat.SecondName = query.SecondName;
                //dat.Email = query.Email;
                //dat.location = query.location;
            }

            _context.SaveChanges();


            //return View(query);
            return Json(new { success = true, message = message }, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult ShowList() {
        //    var vm = _context.EnqueryTables.ToList();
        //    return PartialView("_Query",vm);
        //}

       
    }
}