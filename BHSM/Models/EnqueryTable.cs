using System;
using System.ComponentModel.DataAnnotations;

namespace BHSM.Models
{
    public class EnqueryTable
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name ="Last Name")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

      

        [Display(Name ="Country")]
        [Required]
        public string location { get; set; }

        [MaxLength(2000)]
        [Required]
        [Display(Name = "Enquiries")]
        public string Question { get; set; }


        
        public string Answer { get; set; }




    }
}