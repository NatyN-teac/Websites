using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;
using BHSM.Models;
using System.IO;
using System.Data.Entity.Validation;


namespace BHSM.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private ApplicationDbContext _context;


        public DepartmentController()
        {
            _context = new ApplicationDbContext();
        }
       
        public ActionResult CreateDepartment() {

            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult CreateDepar(Department department) {
          //string result = "";
          //if(!ModelState.IsValid) {
          //      result = "All Fields Required!";
          //}else {
          //      string fileName = Path.GetFileNameWithoutExtension(department.DepartmentImage.FileName);

          //      string extension = Path.GetExtension(department.DepartmentImage.FileName);

          //      fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
          //      department.DepartmentImageUrl = fileName;
          //      department.DepartmentImage.SaveAs(Path.Combine(Server.MapPath("~/images/DepartmentImage"), fileName));

          //      _context.Departments.Add(department);
          //      _context.SaveChanges();


          //      result += "Successfully Added";
//            }





            //at this point redirect to index page of department to show newly added valu
           //return Json(result, JsonRequestBehavior.AllowGet);
           // return View("successPage");
            

        //}
    
    }
}
