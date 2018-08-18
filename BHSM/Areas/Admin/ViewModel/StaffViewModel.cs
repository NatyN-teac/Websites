using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BHSM.Areas.Admin.Models;

namespace BHSM.Areas.Admin.ViewModel
{
    public class StaffViewModel
    {

    [Display(Name = "Choose Department")]
        public IEnumerable<Department> Departments { get; set; }

        [NotMapped]
        public HttpPostedFileBase ProfileImage { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Specialization { get; set; }


        [Required]
        public string AcademicRank { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string PersonalStatement { get; set; }


        public int DepartmentId { get; set; }

        [Required]
        public string imageUrl { get; set; }


        
        










    }
}