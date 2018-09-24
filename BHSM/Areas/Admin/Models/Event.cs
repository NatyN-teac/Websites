using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class Event
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
        public string HostedBy { get; set; }

      



    }
}