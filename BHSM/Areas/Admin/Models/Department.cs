using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Dep_Description { get; set; }
        public string Dep_Related_Article { get; set; }
        public string Dep_ImagePath { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageUploading { get; set; }


    }
}