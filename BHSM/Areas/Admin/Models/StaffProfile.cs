using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Areas.Admin.Models
{
    public class StaffProfile
    {
        public StaffProfile()
        {
            imageUrl = "~/AppFiles/images/Contact.jpg";
        }
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]

        public string SecondName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string imageUrl { get; set; }

        [Required]
        public string DepName { get; set; }


        [NotMapped]
        public HttpPostedFileBase ProfileImage { get; set; }


        [Required]
        public string Gender { get; set; }


        [Required]
        public string Nationality { get; set; }

        [Required]
        public string AcademicRank { get; set; }

        [Required]
        public string Status { get; set; }

       [Required]
        public string Specialization { get; set; }

       
        public string AdditionalResponsibility { get; set; }


        [Required]
        public string PersonalStatement { get; set; }

        public string EducationalBackground { get; set; }

        public string WorkHistory { get; set; }

       
        public string ContributionToScienceAndResearch { get; set; }

       
        public string LinkdenLink { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]

        public string Office { get; set; }


        public Department Department { get; set; }

    
        public int DepartmentId { get; set; }






    }
}