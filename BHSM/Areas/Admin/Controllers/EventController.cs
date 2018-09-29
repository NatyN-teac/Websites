using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;
using BHSM.Areas.Admin.ViewModel;

namespace BHSM.Areas.Admin.Controllers
{
    public class EventController : Controller
    {

        private ApplicationDbContext _context;

        public EventController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Admin/Event
        public ActionResult EventIndex()
        {
            var Events = _context.Events.ToList();
            return View(Events);
        }


        
        public ActionResult Create(EventViewModel vm) {

            return View();
        }

        public ActionResult Save(EventViewModel vm) {

            string fileName = Path.GetFileNameWithoutExtension(vm.EventImage.FileName);

            string extension = Path.GetExtension(vm.EventImage.FileName);

            fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
            vm.RelatedImage = fileName;
            vm.EventImage.SaveAs(Path.Combine(Server.MapPath("~/images/Events"), fileName));

            var events = new Event
            {
                Title = vm.Title,
                Description = vm.Description,
                HostedBy = vm.HostedBy,
                PostedDate = DateTime.Now,
                RelatedImage = vm.RelatedImage,

            };

            if(vm.Id == 0) {
                _context.Events.Add(events);
            }
            else {
                var eventInDb = _context.Events.Single(s => s.Id == vm.Id);


                eventInDb.Title = vm.Title;
                eventInDb.HostedBy = vm.HostedBy;
                eventInDb.PostedDate = DateTime.Now;
                eventInDb.Description = vm.Description;
                eventInDb.RelatedImage = vm.RelatedImage;
            }
           
            _context.SaveChanges();



            return RedirectToAction("Create");

        }

        public ActionResult GetEvents()
        {

            var Events = _context.Events.ToList();


            return Json(new { data = Events }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEvent([FromUri]int id)
        {
            var events = _context.Events.SingleOrDefault(s => s.Id == id);


            return View(events);
        }

        public ActionResult EditEvent([FromUri] int id ) {

            var staff = _context.Events.SingleOrDefault(s => s.Id == id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            var events = new EventViewModel
            {
                Title = staff.Title,
                HostedBy = staff.HostedBy,
                Description = staff.Description,
                RelatedImage = staff.RelatedImage,

            };

            return View("Create", events);

        }
    }
}