using BHSM.Models;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;
using System.Linq;
using System.Web.Http;

namespace BHSM.Areas.Admin.Controllers
{
    public class EnqueryController : Controller
    {
        private ApplicationDbContext _context;


        public EnqueryController()
        {
            _context = new ApplicationDbContext();
        }

    
        // GET: Admin/Enquery
        public ActionResult Index()
        {
            var query = _context.EnqueryTables.ToList();
           
            return View(query);
        }

        //public ActionResult Answer()
        //{
        //    var model = _context.EnqueryTables;

        //    return View(model);
        //}

        public ActionResult Answer([FromUri] int id)
        {
            var answerQuery = _context.EnqueryTables.SingleOrDefault(q => q.Id == id);

            return View(answerQuery);
        }

        public ActionResult Save([FromUri] int id,EnqueryTable query)
        {
           
                var dat = _context.EnqueryTables.SingleOrDefault(m => m.Id == id);
                dat.Answer = query.Answer;
                //dat.Question = query.Question;
                //dat.FirstName = query.FirstName;
                //dat.SecondName = query.SecondName;
                //dat.Email = query.Email;
                //dat.location = query.location;
            

            _context.SaveChanges();


            //return View(query);
            return Json(new { success = true, message = "successfully Submitted" }, JsonRequestBehavior.AllowGet);
        }



        public ActionResult SaveAnswer(EnqueryTable enq) {

            var answerQuery = _context.EnqueryTables.SingleOrDefault(q => q.Id == enq.Id);

            answerQuery.Answer = enq.Answer;
            //answerQuery.location = enq.location;
            //answerQuery.Question = enq.Question;
            //answerQuery.FirstName = enq.FirstName;
            //answerQuery.SecondName = enq.SecondName;
            //answerQuery.Email = enq.Email;


            _context.SaveChanges();
            return View("Index");

        }


    }
}