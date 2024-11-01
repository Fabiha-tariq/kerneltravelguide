﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace KernelTravelGuides.Models
{
    public class Hotel
    {
        [Key]
        public int hotel_id { get; set; }

        [Required]
        [Display(Name = "Hotel Name")]
        public string hotel_name { get; set; }

        [Required]
        [Display(Name = "Hotel Rating")]
        public int hotel_rating { get; set; }

        [Required]
        [Display(Name = "Hotel Average")]
        public string hotel_average { get; set; }

        [Required]
        [Display(Name = "Hotel Image")]
        public string hotel_image { get; set; }


        [Required]
        [Display(Name = "Hotel Status")]
        public bool hotel_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Hotel Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;


        [NotMapped]
        public IFormFile main_image { get; set; }

    }


  
}
