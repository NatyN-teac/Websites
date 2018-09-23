using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BHSM.Areas.Admin.Models;

namespace BHSM.Areas.Admin.ViewModel
{
    public class StaffViewModel
    {

        public StaffViewModel()
        {
            imageUrl = "~/AppFiles/images/Contact.jpg";
        }

        public int Id { get; set; }
        [Display(Name = "Choose Department")]
        public IEnumerable<Department> Departments { get; set; }

        [NotMapped]
        public HttpPostedFileBase ProfileImage { get; set; }

        [Required]
        public string imageUrl { get; set; }

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
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string Office { get; set; }


        [Required]
        public string Specialization { get; set; }


        [Required]
        [Display(Name ="Academic Rank")]
        public string AcademicRank { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        [Display(Name ="Personal Statement")]
        [MaxLength(1000000)]
        public string PersonalStatement { get; set; }

        [Display(Name ="Additional Responsibilities")]
        [Required]
        public string AdditionalResponsibility { get; set; }

        [Display(Name ="Educational Background")]
        [MaxLength(1000000)]
        [Required]
        public string EducationalBackground { get; set; }

        
        [Display(Name ="Work Experience")]
        [MaxLength(1000000)]
        [Required]
        public string WorkHistory { get; set; }

        [Display(Name ="Contribution To Science")]
        [MaxLength(1000000)]
        [Required]
        public string ContributionToScienceAndResearch { get; set; }

        [Display(Name = "Web Link")]
       
        public string LinkdenLink { get; set; }
        


        public int DepartmentId { get; set; }

       

        //staffEducationHistoryVM


        
        










    }
}