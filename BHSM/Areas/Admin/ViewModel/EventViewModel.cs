using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.ViewModel
{
    public class EventViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime PostedDate { get; set; }

        [Required]
        public string RelatedImage { get; set; }

        [Required]
       
        public HttpPostedFileBase EventImage { get; set; }


        [Required]
        [Display(Name ="Created By:")]
        public string HostedBy { get; set; }

    }
}