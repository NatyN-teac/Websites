using System.ComponentModel.DataAnnotations;

namespace BHSM.Areas.Admin.Models
{
    public class ChsRole
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]

        public string Name { get; set; }

    }
}