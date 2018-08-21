using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
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


        // GET: Admin/StaffProfile
        public ActionResult NewStaff()
        {
            var department = _context.Departments.ToList();
            var vModel = new StaffViewModel
            {
                Departments = department
            };
          

            return View(vModel);
        }


        [HttpPost]
        
        public ActionResult Create(StaffViewModel staff) {

            //if (!ModelState.IsValid) {
            //    return View("NewStaff"); 

            //    }
            //    else { 
       

            string fileName = Path.GetFileNameWithoutExtension(staff.ProfileImage.FileName);

                string extension = Path.GetExtension(staff.ProfileImage.FileName);

                fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                staff.imageUrl = fileName;
                staff.ProfileImage.SaveAs(Path.Combine(Server.MapPath("~/images/staff"), fileName));



                var stf = new StaffProfile
                {
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

                _context.StaffProfiles.Add(stf);
                _context.SaveChanges();
            //}
           

            return View();

        }
    }
}