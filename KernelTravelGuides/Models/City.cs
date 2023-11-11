using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class City
    {
        [Key]
        public int city_id { get; set; }

        [Required]
        [Display(Name = "City Name")]
        public string city_name { get; set; }

      
        [Required]
        [Display(Name = "City Image")]
        public string city_image { get; set; }


        [Required]
        [Display(Name = "Cty Status")]
        public bool city_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "City Created Time")]
        public DateTime created_at { get; set; }


      
        [DataType(DataType.DateTime)]
        [Display(Name = "City Updated Time")]
        public DateTime updated_at { get; set; }

        [NotMapped]
        public IFormFile main_image { get; set; }

        public class CityCreatedate : City
        {

            public CityCreatedate()
            {
                created_at = DateTime.UtcNow;
            }

           


        }

        public class CityUpdatedat : City
        {

            public CityUpdatedat()
            {
                created_at = DateTime.UtcNow;
            }




        }

    }
}
