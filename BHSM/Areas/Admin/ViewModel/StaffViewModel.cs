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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Middle Name")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
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


        public string AdditionalResponsibility { get; set; }

        public string EducationalBackground { get; set; }
        public string WorkHistory { get; set; }
        public string ContributionToScienceAndResearch { get; set; }

        public string LinkdenLink { get; set; }
        


        public int DepartmentId { get; set; }

        [Required]
        public string imageUrl { get; set; }

        //staffEducationHistoryVM


        
        










    }
}