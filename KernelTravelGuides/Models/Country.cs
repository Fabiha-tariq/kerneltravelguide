using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KernelTravelGuides.Models
{
    public class Country
    {
        [Key] 
        public int country_id { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        public string country_name { get; set; }

        [Required]
        [Display(Name = "Country Code")]
        public string country_code { get; set; }

        [Required]
        [Display(Name = "Country Image")]
        public string country_image { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Country Currency")]
        public string country_currency { get; set; }

        [Required]
        [Display(Name = "Country Status")]
        public bool status { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Country Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;


        [NotMapped]
        public IFormFile main_image { get; set; }

    }


   
}
