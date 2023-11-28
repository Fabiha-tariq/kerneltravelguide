using System.ComponentModel.DataAnnotations;

namespace KernelTravelGuides.Models
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }

        [Required]
        public string feedback_user_name { get; set;  }


        [Required]
        [MaxLength(400)]
        public string feedback_desc { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Feedback Timing")]
        public DateTime created_at { get; set; } = DateTime.Now;

    }
}
