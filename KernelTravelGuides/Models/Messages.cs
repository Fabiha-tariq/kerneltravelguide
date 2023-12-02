using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class Messages
    {
        [Key]
        public int messages_id { get; set; }

        [Required]
        [Display(Name = "Messages User Name")]
        public string messages_user_name { get; set; }

        [Required]
        [MaxLength(8000)]
        [Display(Name = "Messages Description")]
        public string messages_desc { get; set; }

        

        [Required]
        [Display(Name = "Messages Content")]
        public string messages_content { get; set; }



        [DataType(DataType.DateTime)]
        [Display(Name = "Messages Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;


    }
}
