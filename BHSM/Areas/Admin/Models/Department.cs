using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Description")]
        public string Dep_Description { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name ="Article")]
        public string Dep_Related_Article { get; set; }

        [Display(Name = "Image")]
        public string Dep_ImagePath { get; set; }

      


        [NotMapped]
        public HttpPostedFileBase ImageUploading { get; set; }

        public Department()
        {
            Dep_ImagePath = "~/AppFiles/Images/Contact.jpg";
        }
    }
}