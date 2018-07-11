using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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

        [HttpGet]
        public ActionResult Edit(string id) {

            var result = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            //var result = _context.Users.ToList();
            if(result != null) {
                Console.WriteLine(result);

                var data = new RegisterViewModel
                {
                    Email = result.Email,
                    Name = "hi man"
                };

                return View(data);
            }
            else {
                return Content("not found");
            }
           

        }
    }
}