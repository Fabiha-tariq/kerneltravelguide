using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class Packages
    {
        [Key]
        public int packages_id { get; set; }

        [Required]
        [Display(Name = "Packages Name")]
        public string packages_name { get; set; }

        [MaxLength(8000)]
        [Required]
        [Display(Name = "Packages Desc")]
        public string packages_desc { get; set; }

        [Required]
        [Display(Name = "Packages Price")]
        public int packages_or_price { get; set; }

        [Required]
        [Display(Name = "Packages Images")]
        public string packages_img { get; set; }


        public int resorts_id { get; set; }
        [ForeignKey("resorts_id")]
        public Resorts resorts { get; set; }

        public int tra_category_id { get; set; }
        [ForeignKey("tra_category_id")]
        public TravelCategory tra_category { get; set; }

        public int t_spot_id { get; set; }
        [ForeignKey("t_spot_id")]
        public TouriestSpots t_spot { get; set; }

        public int transport_id { get; set; }
        [ForeignKey("transport_id")]
        public Transport transport { get; set; }


        [Required]
        [Display(Name = "Packages Status")]
        public bool packages_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Packages Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;


        [NotMapped]
        public IFormFile main_image { get; set; }

    }

}
