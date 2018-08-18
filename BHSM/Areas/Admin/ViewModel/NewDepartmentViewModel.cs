using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.ViewModel
{

    public class NewDepartmentViewModel
    {
        [Required]
        [Display(Name ="Department Name")]
        public string DepartmentName { get; set; }


        [Required]
        public string DepatmentMoto { get; set; }

        [Required]
        public string DepartmentDescription { get; set; }

        [Required]
        public string DepartmentImageUrl { get; set; }

       
    }
}