using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class Province
    {
           [Key]
            public int province_id { get; set; }

            [Required]
            [Display(Name = "Province Name")]
            public string province_name { get; set; }


            [Required]
            [Display(Name = "Province Image")]
            public string province_image { get; set; }


            [Required]
            [Display(Name = "Province Status")]
            public bool province_status { get; set; }


            [DataType(DataType.DateTime)]
            [Display(Name = "Province Created Time")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [NotMapped]
            public IFormFile main_image { get; set; }

        
    }


   
}

