using System.ComponentModel.DataAnnotations;

namespace BHSM.Models
{
    public class AnswerTable
    {
        public int Id { get; set; }

        public int EnqueryTableId { get; set; }

        [Required]
        [StringLength(3050)]
        public string Answer { get; set; }
        public EnqueryTable EnqueryTable { get; set; }


    }
}