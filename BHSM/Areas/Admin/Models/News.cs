using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="News Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string DetailMessage { get; set; }
        [Required]
        [Display(Name = "Created By")]
        public string HostedBy { get; set; }
      
    }
}