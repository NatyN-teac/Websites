using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;

namespace BHSM.Areas.Admin.Controllers
{
    public class ManageUsersController : Controller
    {

        private ApplicationDbContext _context;

        public ManageUsersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Admin/ManageUsers
        public ActionResult Index()
        {
            var user = _context.Users.ToList();
            return View(user);

        }

        public ActionResult Remove(int id) {
            return View();

        }
        public ActionResult Edit(string userId) {
          
            return View();

        }
    }
}