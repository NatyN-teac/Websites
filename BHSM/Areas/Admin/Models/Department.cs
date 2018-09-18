using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }



        [Required]
        [Display(Name = "Department Moto")]
        public string DepatmentMoto { get; set; }

        
        [Required]
        [StringLength(1000)]
        [Display(Name = "Description")]
        public string DepartmentDescription { get; set; }

        
      
    }
}