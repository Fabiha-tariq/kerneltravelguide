using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class Resorts
    {
        [Key]
        public int resorts_id { get; set; }

        [Required]
        [Display(Name = "Resorts Name")]
        public string resorts_name { get; set; }


        [Required]
        [Display(Name = "Resorts Location")]
        public string resorts_location { get; set; }

        [Required]
        [Display(Name = "Resorts Image 1")]
        public string resorts_img1 { get; set; }

        [Required]
        [Display(Name = "Resorts Image 2")]
        public string resorts_img2 { get; set; }

        [Required]
        [Display(Name = "Resorts Image 3")]
        public string resorts_img3 { get; set; }

        [Required]
        [Display(Name = "Resorts Status")]
        public bool resorts_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Resorts Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [NotMapped]
        public IFormFile main_image1 { get; set; }

        [NotMapped]
        public IFormFile main_image2 { get; set; }

        [NotMapped]
        public IFormFile main_image3 { get; set; }

    }


  
}

