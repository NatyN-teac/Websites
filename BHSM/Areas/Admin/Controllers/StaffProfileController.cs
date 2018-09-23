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
    public class StaffProfileController : Controller
    {
        private ApplicationDbContext _context;

        public StaffProfileController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            var staffs = _context.StaffProfiles.ToList();

            return View(staffs);

        }

        // GET: Admin/StaffProfile
        public ActionResult GetList() {

            var staffs = _context.StaffProfiles.ToList();
            

            return Json(new { data = staffs }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetStaff([FromUri]int id) {
            var staff = _context.StaffProfiles.SingleOrDefault(s => s.Id == id);
           

            return View(staff);
        }

        public ActionResult EditStaff([FromUri] int id) {

            var staff = _context.StaffProfiles.SingleOrDefault(s => s.Id == id);
            if(staff == null) {
                return HttpNotFound();
            }

            var viewModel = new StaffViewModel
            {
                Departments = _context.Departments.ToList(),
                FirstName = staff.FirstName,
               
                DepartmentId = staff.DepartmentId,
               
                SecondName = staff.SecondName,
                LastName = staff.LastName,
                imageUrl = staff.imageUrl,
                Email = staff.Email,
                Gender = staff.Gender,
                Nationality = staff.Nationality,
                Specialization = staff.Specialization,
                Status = staff.Status,
                LinkdenLink = staff.LinkdenLink,
                Office = staff.Office,
                PersonalStatement = staff.PersonalStatement,
                WorkHistory = staff.WorkHistory,
                AcademicRank = staff.AcademicRank,
                EducationalBackground = staff.EducationalBackground,
                ContributionToScienceAndResearch = staff.ContributionToScienceAndResearch,
                AdditionalResponsibility = staff.AdditionalResponsibility



            };

            return View("NewStaff",viewModel);
        
        }

        
        public ActionResult NewStaff()
        {
            var department = _context.Departments.OrderByDescending(m => m.Id).ToList();
            var vModel = new StaffViewModel
            {
                Departments = department
            };


            return View(vModel);
        }



        

        public ActionResult Create(StaffViewModel staff) {
        
          

            string fileName = Path.GetFileNameWithoutExtension(staff.ProfileImage.FileName);

            string extension = Path.GetExtension(staff.ProfileImage.FileName);

            fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
            staff.imageUrl = fileName;
            staff.ProfileImage.SaveAs(Path.Combine(Server.MapPath("~/images/staff"), fileName));

            var depname = _context.Departments.Where(d => d.Id == staff.DepartmentId).Select(d => d.DepartmentName).SingleOrDefault();

            var stf = new StaffProfile
            {
                DepName = depname,
                DepartmentId = staff.DepartmentId,
                FirstName = staff.FirstName,
                SecondName = staff.SecondName,
                LastName = staff.LastName,
                imageUrl = staff.imageUrl,
                Email = staff.Email,
                Gender = staff.Gender,
                Nationality = staff.Nationality,
                Specialization = staff.Specialization,
                Status = staff.Status,
                LinkdenLink = staff.LinkdenLink,
                Office = staff.Office,
                PersonalStatement = staff.PersonalStatement,
                WorkHistory = staff.WorkHistory,
                AcademicRank = staff.AcademicRank,
                EducationalBackground = staff.EducationalBackground,
                ContributionToScienceAndResearch = staff.ContributionToScienceAndResearch,
                AdditionalResponsibility = staff.AdditionalResponsibility




            };

            if (staff.Id == 0)
            {
                _context.StaffProfiles.Add(stf);

            }
            else {
                var staffInDb = _context.StaffProfiles.Single(s => s.Id == staff.Id);


                staffInDb.FirstName = staff.FirstName;
                staffInDb.SecondName = staff.SecondName;
                staffInDb.LastName = staff.LastName;
                staffInDb.Office = staff.Office;
                staffInDb.Email = staff.Email;
                staffInDb.DepName = depname;
                staffInDb.DepartmentId = staff.DepartmentId;
                staffInDb.AcademicRank = staff.AcademicRank;
                staffInDb.AdditionalResponsibility = staff.AdditionalResponsibility;
                staffInDb.ContributionToScienceAndResearch = staff.ContributionToScienceAndResearch;
                staffInDb.Status = staff.Status;
                staffInDb.WorkHistory = staff.WorkHistory;
                staffInDb.Specialization = staff.Specialization;
                staffInDb.PersonalStatement = staff.PersonalStatement;
                staffInDb.imageUrl = staff.imageUrl;
                staffInDb.LinkdenLink = staff.LinkdenLink;
                staffInDb.Nationality = staff.Nationality;
                staffInDb.EducationalBackground = staff.EducationalBackground;
                staffInDb.Gender = staff.Gender;
                
            }


            
            _context.SaveChanges();
            //}



            //return Json(new { success = true, message = "successfully Submitted" }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
            
        }


    

      
    }
}