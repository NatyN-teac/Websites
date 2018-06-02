using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class CHS_Staff
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(1000)]
        [Required]
        public string DescriptionBackground { get; set; }

        [Required]
        public string E_Mail { get; set; }

        public string Address { get; set; }

        [Required]
        public string OfficeAddress { get; set; }

        public DateTime? BirthDate { get; set; }

        public string ImagePath { get; set; }



        [NotMapped]
       public HttpPostedFileBase ImageUpload { get; set; }


        public CHS_Staff()
        {
            ImagePath = "~/AppFiles/Images/Contact.jpg";
        }


    }
}