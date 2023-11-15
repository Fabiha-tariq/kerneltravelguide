using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class TouriestSpots
    {
        [Key]
        public int t_spot_id { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Name")]
        public string t_spot_name { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Location")]
        public string t_spot_locaion { get; set; }

       
        [MaxLength(8000)]
        [Required]
        [Display(Name = "Touriest Spots Description")]
        public string t_spot_desc { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Rating")]
        public int t_spot_rating { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Image 1")]
        public string t_spot_img1 { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Image 2")]
        public string t_spot_img2 { get; set; }

        [Required]
        [Display(Name = "Touriest Spots Image 3")]
        public string t_spot_img3 { get; set; }


        [Required]
        [Display(Name = "Touriest Spots Status")]
        public bool t_spot_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Touriest Spots Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [NotMapped]
        public IFormFile main_image1 { get; set; }

        [NotMapped]
        public IFormFile main_image2 { get; set; }

        [NotMapped]
        public IFormFile main_image3 { get; set; }

    

    }
}
