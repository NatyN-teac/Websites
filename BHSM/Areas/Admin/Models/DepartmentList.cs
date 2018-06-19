using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class DepartmentList
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Dep_Summary { get; set; }
        public string Dep_Article { get; set; }
    }
}