using BHSM.Models;
using System.Web.Mvc;

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
            return View();
        }

        public ActionResult Answer()
        {
            var model = _context.EnqueryTables;

            return View(model);
        }

        
    }
}