using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class Restaurants
    {
        [Key]
        public int restaurants_id { get; set; }

        [Required]
        [Display(Name = "Restaurants Name")]
        public string restaurants_name { get; set; }


        [Required]
        [Display(Name = "Restaurants Location")]
        public string restaurants_location { get; set; }


        [Required]
        [Display(Name = "Restaurants Image")]
        public string restaurants_image { get; set; }


        [Required]
        [Display(Name = "Restaurants Status")]
        public bool restaurants_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Restaurants Created Time")]
        public DateTime created_at { get; set; }



        [DataType(DataType.DateTime)]
        [Display(Name = "Restaurants Updated Time")]
        public DateTime updated_at { get; set; }

        [NotMapped]
        public IFormFile main_image { get; set; }

    }
}
